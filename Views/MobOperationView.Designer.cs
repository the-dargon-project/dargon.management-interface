namespace Dargon.Management.Views {
   partial class MobOperationView {
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
         this.returnTypeLabel = new System.Windows.Forms.Label();
         this.invocationButton = new System.Windows.Forms.Button();
         this.mobParameterListView = new Dargon.Management.Views.MobParameterListView();
         this.flowLayoutPanel.SuspendLayout();
         this.SuspendLayout();
         // 
         // flowLayoutPanel
         // 
         this.flowLayoutPanel.AutoSize = true;
         this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.flowLayoutPanel.Controls.Add(this.returnTypeLabel);
         this.flowLayoutPanel.Controls.Add(this.invocationButton);
         this.flowLayoutPanel.Controls.Add(this.mobParameterListView);
         this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
         this.flowLayoutPanel.Name = "flowLayoutPanel";
         this.flowLayoutPanel.Size = new System.Drawing.Size(592, 29);
         this.flowLayoutPanel.TabIndex = 0;
         // 
         // returnTypeLabel
         // 
         this.returnTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.returnTypeLabel.AutoSize = true;
         this.returnTypeLabel.Location = new System.Drawing.Point(3, 0);
         this.returnTypeLabel.Name = "returnTypeLabel";
         this.returnTypeLabel.Size = new System.Drawing.Size(88, 29);
         this.returnTypeLabel.TabIndex = 0;
         this.returnTypeLabel.Text = "The.Return.Type";
         this.returnTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // invocationButton
         // 
         this.invocationButton.AutoSize = true;
         this.invocationButton.Location = new System.Drawing.Point(97, 3);
         this.invocationButton.Name = "invocationButton";
         this.invocationButton.Size = new System.Drawing.Size(84, 23);
         this.invocationButton.TabIndex = 1;
         this.invocationButton.Text = "Method Name";
         this.invocationButton.UseVisualStyleBackColor = true;
         this.invocationButton.Click += new System.EventHandler(this.HandleInvocationButtonClick);
         // 
         // mobParameterListView
         // 
         this.mobParameterListView.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.mobParameterListView.AutoSize = true;
         this.mobParameterListView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.mobParameterListView.Location = new System.Drawing.Point(184, 4);
         this.mobParameterListView.Margin = new System.Windows.Forms.Padding(0);
         this.mobParameterListView.Name = "mobParameterListView";
         this.mobParameterListView.Size = new System.Drawing.Size(408, 20);
         this.mobParameterListView.TabIndex = 2;
         // 
         // MobOperationView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.Controls.Add(this.flowLayoutPanel);
         this.Margin = new System.Windows.Forms.Padding(0);
         this.Name = "MobOperationView";
         this.Size = new System.Drawing.Size(595, 32);
         this.flowLayoutPanel.ResumeLayout(false);
         this.flowLayoutPanel.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
      private System.Windows.Forms.Label returnTypeLabel;
      private System.Windows.Forms.Button invocationButton;
      private MobParameterListView mobParameterListView;
   }
}
