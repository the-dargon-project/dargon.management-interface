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
   public partial class MobView : UserControl {
      public MobView() {
         InitializeComponent();
      }

      public void SetController(IMobsController controller) {
         mobOperationsView.SetController(controller);
      }

      public void SetParameterViewFactory(ParameterViewFactory parameterViewFactory) {
         this.mobOperationsView.SetParameterViewFactory(parameterViewFactory);
      }

      public void Initalize() {
         mobOperationsView.Initialize();
      }
   }
}
