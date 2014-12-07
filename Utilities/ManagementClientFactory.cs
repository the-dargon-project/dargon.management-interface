using Dargon.Management.Client;
using Dargon.PortableObjects;
using ItzWarty.Collections;
using ItzWarty.Networking;
using ItzWarty.Threading;

namespace Dargon.Management.Utilities {
   public interface IManagementClientFactory {
      ManagementClient CreateUninitializedClient(ITcpEndPoint tcpEndPoint);
   }

   public class ManagementClientFactory : IManagementClientFactory {
      private readonly ICollectionFactory collectionFactory;
      private readonly IThreadingProxy threadingProxy;
      private readonly IPofSerializer pofSerializer;
      private readonly INetworkingProxy networkingProxy;

      public ManagementClientFactory(ICollectionFactory collectionFactory, IThreadingProxy threadingProxy, IPofSerializer pofSerializer, INetworkingProxy networkingProxy) {
         this.collectionFactory = collectionFactory;
         this.threadingProxy = threadingProxy;
         this.pofSerializer = pofSerializer;
         this.networkingProxy = networkingProxy;
      }

      public ManagementClient CreateUninitializedClient(ITcpEndPoint tcpEndPoint) {
         var socket = networkingProxy.CreateConnectedSocket(tcpEndPoint);
         var client = new ManagementClient(collectionFactory, threadingProxy, pofSerializer, socket);
         return client;
      }
   }
}
