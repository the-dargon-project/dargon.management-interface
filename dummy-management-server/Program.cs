using Dargon.Management.Client;
using Dargon.Management.Server;
using Dargon.PortableObjects;
using ItzWarty.Collections;
using ItzWarty.IO;
using ItzWarty.Networking;
using ItzWarty.Threading;
using System;
using System.Threading;
using System.Windows.Forms;
using Dargon.SomethingElse;
using ItzWarty;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace Dargon.Management {
   public static class Program {
      [STAThread]
      public static void Main(string[] args) {
         Application.EnableVisualStyles();

         InitializeLogging();
         ICollectionFactory collectionFactory = new CollectionFactory();
         IThreadingFactory threadingFactory = new ThreadingFactory();
         ISynchronizationFactory synchronizationFactory = new SynchronizationFactory();
         IThreadingProxy threadingProxy = new ThreadingProxy(threadingFactory, synchronizationFactory);
         IPofContext pofContext = new ManagementPofContext();
         IPofSerializer pofSerializer = new PofSerializer(pofContext);
         IDnsProxy dnsProxy = new DnsProxy();
         ITcpEndPointFactory tcpEndPointFactory = new TcpEndPointFactory(dnsProxy);
         IStreamFactory streamFactory = new StreamFactory();
         INetworkingInternalFactory networkingInternalFactory = new NetworkingInternalFactory(threadingProxy, streamFactory);
         ISocketFactory socketFactory = new SocketFactory(tcpEndPointFactory, networkingInternalFactory);
         INetworkingProxy networkingProxy = new NetworkingProxy(socketFactory, tcpEndPointFactory);

         const int port = 21000;
         Console.WriteLine("Start dummy management server at port {0}.".F(port));
         var serverEndpoint = tcpEndPointFactory.CreateAnyEndPoint(port);
         IManagementServerConfiguration configuration = new ManagementServerConfiguration(serverEndpoint);
         ManagementFactoryImpl managementFactory = new ManagementFactoryImpl(collectionFactory, threadingProxy, networkingProxy, pofContext, pofSerializer);
         var server = managementFactory.CreateServer(configuration);

         server.RegisterInstance(new DummyMob());
         server.RegisterInstance(new HerpMob());
         server.RegisterInstance(new OtherDummyMob());

         Console.WriteLine("Dummy management server initialized.");

         Application.Run();
      }

      private static void InitializeLogging() {
         var config = new LoggingConfiguration();
         var debuggerTarget = new DebuggerTarget();
         config.AddTarget("debugger", debuggerTarget);

         var rule2 = new LoggingRule("*", LogLevel.Trace, debuggerTarget);
         config.LoggingRules.Add(rule2);
         LogManager.Configuration = config;
      }
   }
}
