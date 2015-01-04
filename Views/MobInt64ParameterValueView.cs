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
   public partial class MobInt64ParameterValueView : UserControl {
      private readonly MobOperationParameterViewModel model;
      private readonly Color defaultTextboxBackgroundColor;

      public MobInt64ParameterValueView() { InitializeComponent(); }

      public MobInt64ParameterValueView(MobOperationParameterViewModel model) {
         InitializeComponent();
         this.model = model;
         this.textBox.KeyPress += HandleKeyPress;
         this.textBox.KeyDown += HandleKeyDown;
         defaultTextboxBackgroundColor = textBox.BackColor;
         model.Value = 0;
      }

      private void HandleKeyPress(object sender, KeyPressEventArgs e) {
         const char kDelete = (char)8;
         e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != kDelete;
      }

      private void HandleKeyDown(object sender, KeyEventArgs e) {
         // Use begininvoke so we process text after the key event.
         BeginInvoke(new Action(() => {
            if (model != null) {
               long value;
               if (Int64.TryParse(textBox.Text, out value)) {
                  model.Value = (Int64)value;
                  textBox.BackColor = defaultTextboxBackgroundColor;
               } else {
                  textBox.BackColor = Color.LightPink;
               }
            }
         }));
      }
   }
}
