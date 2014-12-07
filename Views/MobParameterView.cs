using Dargon.Management.ViewModels;
using System.Windows.Forms;

namespace Dargon.Management.Views {
   public partial class MobParameterView : UserControl {

      internal MobParameterView() {
         InitializeComponent();
      }

      public MobParameterView(MobOperationParameterViewModel model, UserControl parameterView) {
         InitializeComponent();

         parameterNameLabel.Text = model.Name;
         flowLayoutPanel.Controls.Remove(placeholderParameterView);
         flowLayoutPanel.Controls.Add(parameterView);
      }
   }
}
