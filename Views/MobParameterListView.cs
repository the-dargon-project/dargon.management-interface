using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dargon.Management.Models;
using Dargon.Management.ViewModels;

namespace Dargon.Management.Views {
   public partial class MobParameterListView : UserControl {
      private ParameterViewFactory parameterViewFactory;

      public MobParameterListView() {
         InitializeComponent();
      }

      public void SetParameterViewFactory(ParameterViewFactory parameterViewFactory) {
         this.parameterViewFactory = parameterViewFactory;
      }

      public void Update(IReadOnlyList<MobOperationParameterViewModel> models) {
         var container = innerFlowLayoutPanel.Controls;
         container.Clear();
         for (var i = 0; i < models.Count; i++) {
            if (i > 0) {
               container.Add(new MobParameterDelimiterView());
            }

            var model = models[i];
            var view = new MobParameterView(model, parameterViewFactory);
            container.Add(view);
         }
      }
   }
}
