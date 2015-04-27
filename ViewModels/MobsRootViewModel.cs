using Dargon.Management.Controllers;
using System;

namespace Dargon.Management.ViewModels {
   public class MobsRootViewModel {
      public event EventHandler MobViewModelChanged;
      private readonly MobsTreeViewModel treeModel;
      private MobsController controller;
      private MobViewModel currentMobViewModel;

      public MobsRootViewModel() {
         this.treeModel = new MobsTreeViewModel();
      }

      public MobsTreeViewModel TreeModel { get { return treeModel; } }
      public MobViewModel MobViewModel { get { return currentMobViewModel; } }

      public void SetController(MobsController controller) {
         this.controller = controller;
         treeModel.SetController(controller);
      }

      public void SetCurrentMobViewModel(MobViewModel mobViewModel) {
         this.currentMobViewModel = mobViewModel;
         OnMobViewModelChanged();
      }

      protected virtual void OnMobViewModelChanged() {
         var handler = MobViewModelChanged;
         if (handler != null) {
            handler(this, EventArgs.Empty);
         }
      }
   }
}
