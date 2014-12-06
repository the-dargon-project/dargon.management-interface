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
using Dargon.Management.Models;
using Dargon.Management.ViewModels;

namespace Dargon.Management.Views {
   public partial class MobOperationView : UserControl {
      private readonly Guid mobGuid;
      private readonly MobOperationViewModel operationViewModel;
      private readonly IMobsController controller;

      public MobOperationView() { InitializeComponent(); }

      public MobOperationView(Guid mobGuid, MobOperationViewModel operationViewModel, IMobsController controller, ParameterViewFactory parameterViewFactory) {
         InitializeComponent();
         this.mobGuid = mobGuid;
         this.operationViewModel = operationViewModel;
         this.controller = controller;

         this.returnTypeLabel.Text = controller.GetPofTypeIdName(operationViewModel.ReturnPofTypeId);
         this.invocationButton.Text = operationViewModel.Name;

         mobParameterListView.SetParameterViewFactory(parameterViewFactory);
         this.mobParameterListView.Update(operationViewModel.ParameterViewModels);
      }

      private void HandleInvocationButtonClick(object sender, EventArgs e) {
         controller.Invoke(mobGuid, operationViewModel);
      }
   }
}
