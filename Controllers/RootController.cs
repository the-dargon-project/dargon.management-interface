using Dargon.Management.Client;
using Dargon.Management.ViewModels;
using Dargon.PortableObjects;

namespace Dargon.Management.Controllers {
   public class RootController {
      private readonly MobsRootViewModel mobsRootViewModel;
      private readonly IMobsController mobsController;
      private readonly ConnectionController connectionController;

      public RootController(MobsRootViewModel mobsRootViewModel, IMobsController mobsController, ConnectionController connectionController) {
         this.mobsRootViewModel = mobsRootViewModel;
         this.mobsController = mobsController;
         this.connectionController = connectionController;
      }

      public void Initialize() {
         this.connectionController.Connected += HandleClientConnected;
      }

      public void HandleClientConnected(IManagementClient client) {
         // Initialize subcontrollers first to prevent event race conditions.
         mobsController.HandleClientInitialized(client);
      }

      public IMobsController GetMobsController() {
         return mobsController;
      }

      public ConnectionController GetConnectionController() {
         return connectionController;
      }
   }
}
