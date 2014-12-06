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
   public partial class MobStringParameterValueView : UserControl {
      private readonly MobOperationParameterViewModel model;

      public MobStringParameterValueView() { InitializeComponent(); }

      public MobStringParameterValueView(MobOperationParameterViewModel model) {
         InitializeComponent();
         this.model = model;
         this.textBox.TextChanged += HandleTextChanged;
         model.Value = "";
      }

      private void HandleTextChanged(object sender, EventArgs e) {
         if (model != null) {
            model.Value = textBox.Text;
         }
      }
   }
}
