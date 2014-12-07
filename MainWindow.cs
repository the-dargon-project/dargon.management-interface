using System;
using Dargon.Management.Controllers;
using Dargon.Management.Views;
using System.Windows.Forms;
using Dargon.Management.Models;

namespace Dargon.Management {
   public partial class MainWindow : Form {
      private readonly RootController rootController;
      private readonly ParameterViewFactory parameterViewFactory;
      private readonly ConnectionWindow connectionWindow;
      private readonly ConnectionStateViewModel connectionStateViewModel;
      private readonly string baseText;

      public MainWindow(RootController rootController, ParameterViewFactory parameterViewFactory, ConnectionWindow connectionWindow, ConnectionStateViewModel connectionStateViewModel) {
         InitializeComponent();

         this.rootController = rootController;
         this.parameterViewFactory = parameterViewFactory;
         this.connectionWindow = connectionWindow;
         this.connectionStateViewModel = connectionStateViewModel;

         this.baseText = this.Text;
      }

      public void Initialize() {
         this.mobsPanel.SetController(rootController.GetMobsController());
         this.mobsPanel.SetParameterViewFactory(parameterViewFactory);
         this.mobsPanel.Initialize();

         connectionStateViewModel.PropertyChanged += HandleConnectionStateChanged;

         this.Shown += HandleShown;
      }

      private void HandleConnectionStateChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
         BeginInvoke(new Action(() => {
            Text = baseText + " (" + connectionStateViewModel.Destination + ")";
         }));
      }

      private void HandleShown(object sender, EventArgs e) {
         var dialogResult = connectionWindow.ShowDialog();
         if (dialogResult == DialogResult.Cancel) {
            Close();
         }
      }
   }
}
