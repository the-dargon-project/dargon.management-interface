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

namespace Dargon.Management.Views {
   public partial class MobsPanel : UserControl {
      private IMobsController controller;

      public MobsPanel() {
         InitializeComponent();

         splitContainer.FixedPanel = FixedPanel.Panel1;
      }

      public void SetController(IMobsController controller) {
         this.controller = controller;
         this.mobsTreeView.SetController(controller);
         this.mobView.SetController(controller);
      }

      public void SetParameterViewFactory(ParameterViewFactory parameterViewFactory) {
         this.mobView.SetParameterViewFactory(parameterViewFactory);
      }

      public void Initialize() {
         this.mobsTreeView.Initialize();
         this.mobView.Initalize();
      }
   }
}
