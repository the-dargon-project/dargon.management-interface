using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dargon.Management.Controllers;
using Dargon.Management.ViewModels;

namespace Dargon.Management.Views {
   public partial class MobOperationsView : UserControl {
      private IMobsController controller;
      private MobsRootViewModel mobRootViewModel;
      private ParameterViewFactory parameterViewFactory;

      public MobOperationsView() {
         InitializeComponent();
      }

      public void SetController(IMobsController controller) {
         this.controller = controller;
         this.mobRootViewModel = controller.RootViewModel;
      }

      public void SetParameterViewFactory(ParameterViewFactory parameterViewFactory) {
         this.parameterViewFactory = parameterViewFactory;
      }

      public void Initialize() {
         this.controller.InvocationResult += HandleInvocationResult;

         listPanel.Controls.Clear();
         mobRootViewModel.MobViewModelChanged += (s, e) => HandleNewMobViewModel(mobRootViewModel.MobViewModel);
         if (mobRootViewModel.MobViewModel != null) {
            HandleNewMobViewModel(mobRootViewModel.MobViewModel);
         }
      }

      private void HandleNewMobViewModel(MobViewModel mobViewModel) {
         mobViewModel.Operations.Updated += (s, e) => HandleOperationsViewModelUpdate(mobViewModel.Operations);
         HandleOperationsViewModelUpdate(mobViewModel.Operations);
      }

      private void HandleOperationsViewModelUpdate(MobOperationsViewModel viewModel) {
         BeginInvoke(new Action(() => {
            listPanel.Controls.Clear();
            if (viewModel.Operations != null) {
               foreach (var operationViewModel in viewModel.Operations) {
                  var view = new MobOperationView(mobRootViewModel.MobViewModel.Guid, operationViewModel, controller, parameterViewFactory);
                  listPanel.Controls.Add(view);
               }
            }
         }));
      }

      private void HandleInvocationResult(IMobsController sender, object result) {
         BeginInvoke(new Action(() => {
            MessageBox.Show(this, result == null ? "(null)" : result.ToString());
         }));
      }
   }
}
