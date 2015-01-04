using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dargon.Management.ViewModels;

namespace Dargon.Management.Views {
   public partial class MobInt32ParameterValueView : UserControl {
      private readonly MobOperationParameterViewModel model;

      public MobInt32ParameterValueView() { InitializeComponent(); }

      public MobInt32ParameterValueView(MobOperationParameterViewModel model) {
         InitializeComponent();
         this.model = model;
         this.numericUpDown.ValueChanged += HandleValueChanged;
         model.Value = 0;
      }

      private void HandleValueChanged(object sender, EventArgs e) {
         if (model != null) {
            model.Value = (Int32)numericUpDown.Value;
         }
      }
   }
}
