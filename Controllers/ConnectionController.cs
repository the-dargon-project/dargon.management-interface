using System;
using System.Net.Sockets;
using System.Threading;
using Dargon.Management.Client;
using Dargon.Management.Models;
using Dargon.Management.Utilities;
using ItzWarty;
using ItzWarty.Networking;

namespace Dargon.Management.Controllers {
   public class ConnectionController {
      public event Action<IManagementClient> Connected;
      private readonly INetworkingProxy networkingProxy;
      private readonly IManagementClientFactory managementClientFactory;
      private readonly ConnectionStateViewModel connectionStateViewModel;
      private IManagementClient client;

      public ConnectionController(INetworkingProxy networkingProxy, IManagementClientFactory managementClientFactory, ConnectionStateViewModel connectionStateViewModel) {
         this.networkingProxy = networkingProxy;
         this.managementClientFactory = managementClientFactory;
         this.connectionStateViewModel = connectionStateViewModel;
      }

      public IManagementClient Client { get { return client; } }

      public void ConnectOrThrow(string destination) {
         var endpoint = ParseEndPoint(destination);
         client = managementClientFactory.CreateUninitializedClient(endpoint);
         OnConnected(client);
         client.Initialize();
         connectionStateViewModel.Destination = destination;
      }

      private ITcpEndPoint ParseEndPoint(string destination) {
         var parts = destination.Split(':');
         if (parts.Length != 2) {
            throw new ArgumentException("Endpoint did not meet required <hostname>:<port> format");
         }

         string host = parts[0];
         int port;
         if (!int.TryParse(parts[1], out port)) {
            throw new ArgumentException("Unable to parse port '{0}'".F(parts[1]));
         }

         return networkingProxy.CreateEndPoint(host, port);
      }

      protected virtual void OnConnected(IManagementClient obj) {
         var capture = Connected;
         if (capture != null) {
            capture(obj);
         }
      }
   }
}