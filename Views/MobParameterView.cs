using Dargon.Management.ViewModels;
using System.Windows.Forms;

namespace Dargon.Management.Views {
   public partial class MobParameterView : UserControl {
      private readonly MobOperationParameterViewModel model;

      internal MobParameterView() {
         InitializeComponent();
      }

      public MobParameterView(MobOperationParameterViewModel model, ParameterViewFactory parameterViewFactory) {
         InitializeComponent();

         this.model = model;
         this.parameterNameLabel.Text = model.Name;
         flowLayoutPanel.Controls.Remove(placeholderParameterView);
         flowLayoutPanel.Controls.Add(parameterViewFactory.CreateView(model));
      }
   }
}
