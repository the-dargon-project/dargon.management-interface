using Dargon.Management.Client;
using Dargon.Management.ViewModels;
using Dargon.PortableObjects;

namespace Dargon.Management.Controllers {
   public class RootController {
      private readonly IManagementClient client;
      private readonly MobsRootViewModel mobsRootViewModel;
      private readonly IMobsController mobsController;

      public RootController(IManagementClient client, IPofContext pofContext) {
         this.client = client;
         this.mobsRootViewModel = new MobsRootViewModel();
         this.mobsController = new MobsController(client, mobsRootViewModel, pofContext);
      }

      public void Initialize() {
         // Initialize subcontrollers first to prevent event race conditions.
         mobsController.Initialize();

         // Initialize client after all event handlers are subscribed.
         client.Initialize();
      }

      public IMobsController GetMobsController() {
         return mobsController;
      }
   }
}
