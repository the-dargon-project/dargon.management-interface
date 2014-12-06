using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dargon.Management.Controllers;
using Dargon.Management.Views;

namespace Dargon.Management {
   public partial class MainWindow : Form {
      private readonly RootController rootController;
      private readonly ParameterViewFactory parameterViewFactory;

      public MainWindow(RootController rootController, ParameterViewFactory parameterViewFactory) {
         InitializeComponent();

         this.rootController = rootController;
         this.parameterViewFactory = parameterViewFactory;

         this.mobsPanel.SetController(rootController.GetMobsController());
         this.mobsPanel.SetParameterViewFactory(parameterViewFactory);
      }

      public void Initialize() {
         this.mobsPanel.Initialize();
      }
   }
}
