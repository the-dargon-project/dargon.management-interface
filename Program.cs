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
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Dargon.Management.Models;
using Dargon.Management.Utilities;
using Dargon.Management.ViewModels;
using ItzWarty;

namespace Dargon.Management {
   class Program {
      [STAThread]
      static void Main(string[] args) {
         Application.EnableVisualStyles();

         // args = new[] { "localhost:31000" };

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

         ManagementInterfaceConfiguration configuration;
         if (!TryParseArguments(args, out configuration)) {
            return;
         }

         // initialize management dependencies
         var managementClientFactory = new ManagementClientFactory(collectionFactory, threadingProxy, pofSerializer, networkingProxy);

         // initialize viewmodel dependencies
         var mobsRootViewModel = new MobsRootViewModel();
         var connectionStateViewModel = new ConnectionStateViewModel();

         // initialize controller dependencies
         var mobsController = new MobsController(mobsRootViewModel, pofContext);
         var connectionController = new ConnectionController(networkingProxy, managementClientFactory, connectionStateViewModel);
         var rootController = new RootController(mobsRootViewModel, mobsController, connectionController);
         rootController.Initialize();

         // initialize views
         var parameterViewFactory = new ParameterViewFactory();
         var connectionWindow = new ConnectionWindow(connectionController, configuration, networkingProxy);
         var window = new MainWindow(rootController, connectionController, parameterViewFactory, connectionWindow, connectionStateViewModel);

         // start main windowing thread
         window.Initialize();
         Application.Run(window);
      }

      private static bool TryParseArguments(string[] args, out ManagementInterfaceConfiguration configuration) {
         var input = args.Join(" ");
         var inputTokens = input.QASS(' ');
         configuration = new ManagementInterfaceConfiguration();
         for (var i = 0; i < inputTokens.Length; i++) {
            if (!inputTokens[i].StartsWith("-")) {
               configuration.SetDestination(inputTokens[i]);
            } else {
               Console.Error.WriteLine("Unexpected parameter " + inputTokens[i]);
               return false;
            }
         }
         return true;
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
                  Thread.Sleep(500);
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
