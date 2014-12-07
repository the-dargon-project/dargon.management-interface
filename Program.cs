using Dargon.Management.Client;
using Dargon.Management.Controllers;
using Dargon.Management.Server;
using Dargon.Management.Views;
using Dargon.PortableObjects;
using ItzWarty.Collections;
using ItzWarty.IO;
using ItzWarty.Networking;
using ItzWarty.Threading;
using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Dargon.Management {
   class Program {
      [STAThread]
      static void Main(string[] args) {
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

         const int port = 31000;
         var parameterViewFactory = new ParameterViewFactory();
         var serverEndpoint = tcpEndPointFactory.CreateLoopbackEndPoint(port);
         IConnectedSocket clientSocket = ConnectToServer(networkingProxy, serverEndpoint);
         if (clientSocket == null) {
            MessageBox.Show("Unable to connect to server at given port!");
         } else {
            var client = new ManagementClient(collectionFactory, threadingProxy, pofSerializer, clientSocket);
            var rootController = new RootController(client, pofContext);
            var window = new MainWindow(rootController, parameterViewFactory);
            window.Initialize();
            rootController.Initialize();
            Application.Run(window);
         }
      }

      private static IConnectedSocket ConnectToServer(INetworkingProxy networkingProxy, ITcpEndPoint endpoint) {
         IConnectedSocket result = null;
         for (var i = 0; i < 100 && result == null; i++) {
            try {
               result = networkingProxy.CreateConnectedSocket(endpoint);
               if (i > 0) {
                  Console.WriteLine();
               }
            } catch (SocketException e) {
               if (i == 0) {
                  Console.Write("Connecting.");
               } else {
                  Console.Write(".");
               }
            }
         }
         return result;
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
