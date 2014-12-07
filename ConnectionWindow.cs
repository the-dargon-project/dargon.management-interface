using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dargon.Management.Controllers;
using ItzWarty;
using ItzWarty.Networking;

namespace Dargon.Management {
   public partial class ConnectionWindow : Form {
      private readonly ConnectionController connectionController;
      private readonly ManagementInterfaceConfiguration configuration;

      public ConnectionWindow(ConnectionController connectionController, ManagementInterfaceConfiguration configuration, INetworkingProxy networkingProxy) {
         InitializeComponent();
         this.connectionController = connectionController;
         this.configuration = configuration;

         Extensions.Recursively(
            (Control)hostTargetWrapper,
            SeedInclusion.Include,
            x => x.Click += (s, e) => SelectHostTarget(),
            x => x.Controls.Cast<Control>()
         );

         DialogResult = DialogResult.Cancel;
         Shown += HandleShown;
         connectButton.Click += (s, e) => HandleConnectClicked();
         cancelButton.Click += (s, e) => Close();
         hostAndPortTextBox.PreviewKeyDown += (s, e) => {
            if (e.KeyCode == Keys.Enter) {
               HandleConnectClicked();
            }
         };
         // errorLabel autoresizes to fit text, so we limit its width
         // so it can only expand vertically.
         errorLabel.MaximumSize = new Size(errorLabel.Size.Width, 0);
      }

      private void HandleShown(object sender, EventArgs e) {
         if (configuration.Destination != null) {
            SelectHostTarget();
            hostAndPortTextBox.Text = configuration.Destination;
            HandleConnectClicked();
         } else {
            SelectHostTarget();
            SetEnabled(true);
         }
      }

      private void HandleConnectClicked() {
         var originalFocus = GetFocusedControl();
         errorContainer.Visible = false;
         SetEnabled(false);
         Application.DoEvents();
         try {
            connectionController.ConnectOrThrow(hostAndPortTextBox.Text);
            DialogResult = DialogResult.OK;
            Close();
         } catch (Exception e) {
            SetEnabled(true);
            errorContainer.Visible = true;
            errorLabel.Text = e.GetType().FullName + "\r\n" + e.Message + ".";
            if (originalFocus != null) {
               originalFocus.Focus();
            }
         }
      }

      private void SelectHostTarget() {
         target_hostRadiobutton.Select();
         hostAndPortTextBox.Select();
      }

      private void SetEnabled(bool value) {
         target_hostRadiobutton.Enabled = value;
         hostAndPortTextBox.Enabled = value;

         connectButton.Enabled = value;
         cancelButton.Enabled = value;
      }

      private Control GetFocusedControl() {
         Control currentControl = this;
         while (currentControl is IContainerControl) {
            currentControl = ((IContainerControl)currentControl).ActiveControl;
         }
         return currentControl;
      }
   }
}
