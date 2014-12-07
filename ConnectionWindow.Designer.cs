namespace Dargon.Management {
   partial class ConnectionWindow {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.hostAndPortTextBox = new System.Windows.Forms.TextBox();
         this.wrapper = new System.Windows.Forms.TableLayoutPanel();
         this.headerWrapper = new System.Windows.Forms.TableLayoutPanel();
         this.headerPanel = new System.Windows.Forms.TableLayoutPanel();
         this.headerText = new System.Windows.Forms.Label();
         this.headerIcon = new System.Windows.Forms.PictureBox();
         this.bodyWrapper = new System.Windows.Forms.TableLayoutPanel();
         this.connectionListing = new System.Windows.Forms.TableLayoutPanel();
         this.target_hostRadiobutton = new System.Windows.Forms.RadioButton();
         this.errorContainer = new System.Windows.Forms.TableLayoutPanel();
         this.errorHeader = new System.Windows.Forms.Label();
         this.errorLabel = new System.Windows.Forms.Label();
         this.hostTargetWrapper = new System.Windows.Forms.TableLayoutPanel();
         this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
         this.connectToHostUsageHeader = new System.Windows.Forms.Label();
         this.connectToHostUsageLabel = new System.Windows.Forms.Label();
         this.connectToHostLabel = new System.Windows.Forms.Label();
         this.formActions = new System.Windows.Forms.FlowLayoutPanel();
         this.connectButton = new System.Windows.Forms.Button();
         this.cancelButton = new System.Windows.Forms.Button();
         this.wrapper.SuspendLayout();
         this.headerWrapper.SuspendLayout();
         this.headerPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.headerIcon)).BeginInit();
         this.bodyWrapper.SuspendLayout();
         this.connectionListing.SuspendLayout();
         this.errorContainer.SuspendLayout();
         this.hostTargetWrapper.SuspendLayout();
         this.tableLayoutPanel4.SuspendLayout();
         this.formActions.SuspendLayout();
         this.SuspendLayout();
         // 
         // hostAndPortTextBox
         // 
         this.hostAndPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
         this.hostAndPortTextBox.Location = new System.Drawing.Point(3, 16);
         this.hostAndPortTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
         this.hostAndPortTextBox.Name = "hostAndPortTextBox";
         this.hostAndPortTextBox.Size = new System.Drawing.Size(396, 20);
         this.hostAndPortTextBox.TabIndex = 4;
         // 
         // wrapper
         // 
         this.wrapper.AutoSize = true;
         this.wrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.wrapper.ColumnCount = 1;
         this.wrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.wrapper.Controls.Add(this.headerWrapper, 0, 0);
         this.wrapper.Controls.Add(this.bodyWrapper, 0, 1);
         this.wrapper.Location = new System.Drawing.Point(0, 0);
         this.wrapper.Margin = new System.Windows.Forms.Padding(0);
         this.wrapper.Name = "wrapper";
         this.wrapper.RowCount = 2;
         this.wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.wrapper.Size = new System.Drawing.Size(461, 222);
         this.wrapper.TabIndex = 2;
         // 
         // headerWrapper
         // 
         this.headerWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
         this.headerWrapper.AutoSize = true;
         this.headerWrapper.BackColor = System.Drawing.Color.White;
         this.headerWrapper.ColumnCount = 1;
         this.headerWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.headerWrapper.Controls.Add(this.headerPanel, 0, 0);
         this.headerWrapper.Location = new System.Drawing.Point(0, 0);
         this.headerWrapper.Margin = new System.Windows.Forms.Padding(0);
         this.headerWrapper.Name = "headerWrapper";
         this.headerWrapper.RowCount = 1;
         this.headerWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.headerWrapper.Size = new System.Drawing.Size(461, 94);
         this.headerWrapper.TabIndex = 4;
         // 
         // headerPanel
         // 
         this.headerPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.headerPanel.AutoSize = true;
         this.headerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.headerPanel.BackColor = System.Drawing.Color.White;
         this.headerPanel.ColumnCount = 2;
         this.headerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.headerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.headerPanel.Controls.Add(this.headerText, 1, 0);
         this.headerPanel.Controls.Add(this.headerIcon, 0, 0);
         this.headerPanel.Location = new System.Drawing.Point(88, 0);
         this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
         this.headerPanel.Name = "headerPanel";
         this.headerPanel.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
         this.headerPanel.RowCount = 1;
         this.headerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.headerPanel.Size = new System.Drawing.Size(284, 94);
         this.headerPanel.TabIndex = 3;
         // 
         // headerText
         // 
         this.headerText.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.headerText.AutoSize = true;
         this.headerText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.headerText.Location = new System.Drawing.Point(94, 29);
         this.headerText.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
         this.headerText.Name = "headerText";
         this.headerText.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
         this.headerText.Size = new System.Drawing.Size(167, 35);
         this.headerText.TabIndex = 1;
         this.headerText.Text = "New Connection";
         // 
         // headerIcon
         // 
         this.headerIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.headerIcon.Image = global::Dargon.Management.Properties.Resources.Dargon6464;
         this.headerIcon.Location = new System.Drawing.Point(20, 15);
         this.headerIcon.Margin = new System.Windows.Forms.Padding(0);
         this.headerIcon.Name = "headerIcon";
         this.headerIcon.Size = new System.Drawing.Size(64, 64);
         this.headerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.headerIcon.TabIndex = 0;
         this.headerIcon.TabStop = false;
         // 
         // bodyWrapper
         // 
         this.bodyWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
         this.bodyWrapper.AutoSize = true;
         this.bodyWrapper.ColumnCount = 1;
         this.bodyWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.bodyWrapper.Controls.Add(this.connectionListing, 0, 0);
         this.bodyWrapper.Controls.Add(this.formActions, 0, 1);
         this.bodyWrapper.Location = new System.Drawing.Point(15, 101);
         this.bodyWrapper.Margin = new System.Windows.Forms.Padding(15, 7, 15, 15);
         this.bodyWrapper.Name = "bodyWrapper";
         this.bodyWrapper.RowCount = 2;
         this.bodyWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.bodyWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.bodyWrapper.Size = new System.Drawing.Size(431, 106);
         this.bodyWrapper.TabIndex = 5;
         // 
         // connectionListing
         // 
         this.connectionListing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.connectionListing.AutoSize = true;
         this.connectionListing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.connectionListing.ColumnCount = 2;
         this.connectionListing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.737589F));
         this.connectionListing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.26241F));
         this.connectionListing.Controls.Add(this.target_hostRadiobutton, 0, 0);
         this.connectionListing.Controls.Add(this.errorContainer, 1, 1);
         this.connectionListing.Controls.Add(this.hostTargetWrapper, 1, 0);
         this.connectionListing.Location = new System.Drawing.Point(0, 5);
         this.connectionListing.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
         this.connectionListing.Name = "connectionListing";
         this.connectionListing.RowCount = 2;
         this.connectionListing.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.connectionListing.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.connectionListing.Size = new System.Drawing.Size(431, 69);
         this.connectionListing.TabIndex = 4;
         // 
         // target_hostRadiobutton
         // 
         this.target_hostRadiobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.target_hostRadiobutton.AutoSize = true;
         this.target_hostRadiobutton.Location = new System.Drawing.Point(13, 0);
         this.target_hostRadiobutton.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
         this.target_hostRadiobutton.Name = "target_hostRadiobutton";
         this.target_hostRadiobutton.Size = new System.Drawing.Size(14, 13);
         this.target_hostRadiobutton.TabIndex = 3;
         this.target_hostRadiobutton.TabStop = true;
         this.target_hostRadiobutton.UseVisualStyleBackColor = true;
         // 
         // errorContainer
         // 
         this.errorContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.errorContainer.AutoSize = true;
         this.errorContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.errorContainer.ColumnCount = 2;
         this.errorContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.errorContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.errorContainer.Controls.Add(this.errorHeader, 0, 0);
         this.errorContainer.Controls.Add(this.errorLabel, 1, 0);
         this.errorContainer.Location = new System.Drawing.Point(32, 54);
         this.errorContainer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
         this.errorContainer.Name = "errorContainer";
         this.errorContainer.RowCount = 1;
         this.errorContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.errorContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
         this.errorContainer.Size = new System.Drawing.Size(396, 12);
         this.errorContainer.TabIndex = 4;
         this.errorContainer.Visible = false;
         // 
         // errorHeader
         // 
         this.errorHeader.AutoSize = true;
         this.errorHeader.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
         this.errorHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.errorHeader.Location = new System.Drawing.Point(0, 0);
         this.errorHeader.Margin = new System.Windows.Forms.Padding(0);
         this.errorHeader.Name = "errorHeader";
         this.errorHeader.Size = new System.Drawing.Size(31, 12);
         this.errorHeader.TabIndex = 0;
         this.errorHeader.Text = "Error:";
         // 
         // errorLabel
         // 
         this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.errorLabel.AutoSize = true;
         this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 7F);
         this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.errorLabel.Location = new System.Drawing.Point(31, 0);
         this.errorLabel.Margin = new System.Windows.Forms.Padding(0);
         this.errorLabel.Name = "errorLabel";
         this.errorLabel.Size = new System.Drawing.Size(365, 12);
         this.errorLabel.TabIndex = 1;
         this.errorLabel.Text = "System.IO.SocketException ";
         // 
         // hostTargetWrapper
         // 
         this.hostTargetWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.hostTargetWrapper.AutoSize = true;
         this.hostTargetWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.hostTargetWrapper.ColumnCount = 1;
         this.hostTargetWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.hostTargetWrapper.Controls.Add(this.tableLayoutPanel4, 0, 2);
         this.hostTargetWrapper.Controls.Add(this.connectToHostLabel, 0, 0);
         this.hostTargetWrapper.Controls.Add(this.hostAndPortTextBox, 0, 1);
         this.hostTargetWrapper.Location = new System.Drawing.Point(29, 0);
         this.hostTargetWrapper.Margin = new System.Windows.Forms.Padding(0);
         this.hostTargetWrapper.Name = "hostTargetWrapper";
         this.hostTargetWrapper.RowCount = 3;
         this.hostTargetWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.hostTargetWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.hostTargetWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.hostTargetWrapper.Size = new System.Drawing.Size(402, 54);
         this.hostTargetWrapper.TabIndex = 5;
         // 
         // tableLayoutPanel4
         // 
         this.tableLayoutPanel4.AutoSize = true;
         this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.tableLayoutPanel4.ColumnCount = 2;
         this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel4.Controls.Add(this.connectToHostUsageHeader, 0, 0);
         this.tableLayoutPanel4.Controls.Add(this.connectToHostUsageLabel, 1, 0);
         this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 39);
         this.tableLayoutPanel4.Name = "tableLayoutPanel4";
         this.tableLayoutPanel4.RowCount = 1;
         this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
         this.tableLayoutPanel4.Size = new System.Drawing.Size(132, 12);
         this.tableLayoutPanel4.TabIndex = 3;
         // 
         // connectToHostUsageHeader
         // 
         this.connectToHostUsageHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.connectToHostUsageHeader.AutoSize = true;
         this.connectToHostUsageHeader.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
         this.connectToHostUsageHeader.ForeColor = System.Drawing.SystemColors.GrayText;
         this.connectToHostUsageHeader.Location = new System.Drawing.Point(0, 0);
         this.connectToHostUsageHeader.Margin = new System.Windows.Forms.Padding(0);
         this.connectToHostUsageHeader.Name = "connectToHostUsageHeader";
         this.connectToHostUsageHeader.Size = new System.Drawing.Size(35, 12);
         this.connectToHostUsageHeader.TabIndex = 0;
         this.connectToHostUsageHeader.Text = "Usage:";
         // 
         // connectToHostUsageLabel
         // 
         this.connectToHostUsageLabel.AutoSize = true;
         this.connectToHostUsageLabel.Font = new System.Drawing.Font("Segoe UI", 7F);
         this.connectToHostUsageLabel.ForeColor = System.Drawing.SystemColors.GrayText;
         this.connectToHostUsageLabel.Location = new System.Drawing.Point(35, 0);
         this.connectToHostUsageLabel.Margin = new System.Windows.Forms.Padding(0);
         this.connectToHostUsageLabel.Name = "connectToHostUsageLabel";
         this.connectToHostUsageLabel.Size = new System.Drawing.Size(97, 12);
         this.connectToHostUsageLabel.TabIndex = 1;
         this.connectToHostUsageLabel.Text = "<hostname>:<port>";
         // 
         // connectToHostLabel
         // 
         this.connectToHostLabel.AutoSize = true;
         this.connectToHostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.connectToHostLabel.Location = new System.Drawing.Point(0, 0);
         this.connectToHostLabel.Margin = new System.Windows.Forms.Padding(0);
         this.connectToHostLabel.Name = "connectToHostLabel";
         this.connectToHostLabel.Size = new System.Drawing.Size(103, 13);
         this.connectToHostLabel.TabIndex = 4;
         this.connectToHostLabel.Text = "Connect to Host:";
         // 
         // formActions
         // 
         this.formActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.formActions.AutoSize = true;
         this.formActions.Controls.Add(this.connectButton);
         this.formActions.Controls.Add(this.cancelButton);
         this.formActions.Location = new System.Drawing.Point(268, 77);
         this.formActions.Name = "formActions";
         this.formActions.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
         this.formActions.Size = new System.Drawing.Size(160, 26);
         this.formActions.TabIndex = 3;
         // 
         // connectButton
         // 
         this.connectButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.connectButton.Location = new System.Drawing.Point(5, 3);
         this.connectButton.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
         this.connectButton.Name = "connectButton";
         this.connectButton.Size = new System.Drawing.Size(75, 23);
         this.connectButton.TabIndex = 5;
         this.connectButton.Text = "Connect";
         this.connectButton.UseVisualStyleBackColor = true;
         this.connectButton.Click += new System.EventHandler(this.HandleShown);
         // 
         // cancelButton
         // 
         this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.cancelButton.Location = new System.Drawing.Point(85, 3);
         this.cancelButton.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
         this.cancelButton.Name = "cancelButton";
         this.cancelButton.Size = new System.Drawing.Size(75, 23);
         this.cancelButton.TabIndex = 6;
         this.cancelButton.Text = "Cancel";
         this.cancelButton.UseVisualStyleBackColor = true;
         // 
         // ConnectionWindow
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.ClientSize = new System.Drawing.Size(746, 432);
         this.Controls.Add(this.wrapper);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "ConnectionWindow";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.wrapper.ResumeLayout(false);
         this.wrapper.PerformLayout();
         this.headerWrapper.ResumeLayout(false);
         this.headerWrapper.PerformLayout();
         this.headerPanel.ResumeLayout(false);
         this.headerPanel.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.headerIcon)).EndInit();
         this.bodyWrapper.ResumeLayout(false);
         this.bodyWrapper.PerformLayout();
         this.connectionListing.ResumeLayout(false);
         this.connectionListing.PerformLayout();
         this.errorContainer.ResumeLayout(false);
         this.errorContainer.PerformLayout();
         this.hostTargetWrapper.ResumeLayout(false);
         this.hostTargetWrapper.PerformLayout();
         this.tableLayoutPanel4.ResumeLayout(false);
         this.tableLayoutPanel4.PerformLayout();
         this.formActions.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.TextBox hostAndPortTextBox;
      private System.Windows.Forms.PictureBox headerIcon;
      private System.Windows.Forms.TableLayoutPanel wrapper;
      private System.Windows.Forms.Button connectButton;
      private System.Windows.Forms.Label headerText;
      private System.Windows.Forms.TableLayoutPanel headerPanel;
      private System.Windows.Forms.Label connectToHostLabel;
      private System.Windows.Forms.TableLayoutPanel hostTargetWrapper;
      private System.Windows.Forms.TableLayoutPanel connectionListing;
      private System.Windows.Forms.RadioButton target_hostRadiobutton;
      private System.Windows.Forms.Label connectToHostUsageHeader;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
      private System.Windows.Forms.Label connectToHostUsageLabel;
      private System.Windows.Forms.FlowLayoutPanel formActions;
      private System.Windows.Forms.TableLayoutPanel bodyWrapper;
      private System.Windows.Forms.TableLayoutPanel headerWrapper;
      private System.Windows.Forms.Button cancelButton;
      private System.Windows.Forms.TableLayoutPanel errorContainer;
      private System.Windows.Forms.Label errorHeader;
      private System.Windows.Forms.Label errorLabel;
   }
}