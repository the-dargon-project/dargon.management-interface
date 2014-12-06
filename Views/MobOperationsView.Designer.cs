namespace Dargon.Management.Views {
   partial class MobOperationsView {
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
         this.listPanel = new System.Windows.Forms.FlowLayoutPanel();
         this.mobOperationView1 = new Dargon.Management.Views.MobOperationView();
         this.mobOperationView2 = new Dargon.Management.Views.MobOperationView();
         this.listPanel.SuspendLayout();
         this.SuspendLayout();
         // 
         // listPanel
         // 
         this.listPanel.AutoSize = true;
         this.listPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.listPanel.Controls.Add(this.mobOperationView1);
         this.listPanel.Controls.Add(this.mobOperationView2);
         this.listPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
         this.listPanel.Location = new System.Drawing.Point(0, 0);
         this.listPanel.Margin = new System.Windows.Forms.Padding(0);
         this.listPanel.Name = "listPanel";
         this.listPanel.Size = new System.Drawing.Size(595, 64);
         this.listPanel.TabIndex = 0;
         // 
         // mobOperationView1
         // 
         this.mobOperationView1.AutoSize = true;
         this.mobOperationView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.mobOperationView1.Location = new System.Drawing.Point(0, 0);
         this.mobOperationView1.Margin = new System.Windows.Forms.Padding(0);
         this.mobOperationView1.Name = "mobOperationView1";
         this.mobOperationView1.Size = new System.Drawing.Size(595, 32);
         this.mobOperationView1.TabIndex = 2;
         // 
         // mobOperationView2
         // 
         this.mobOperationView2.AutoSize = true;
         this.mobOperationView2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.mobOperationView2.Location = new System.Drawing.Point(0, 32);
         this.mobOperationView2.Margin = new System.Windows.Forms.Padding(0);
         this.mobOperationView2.Name = "mobOperationView2";
         this.mobOperationView2.Size = new System.Drawing.Size(595, 32);
         this.mobOperationView2.TabIndex = 3;
         // 
         // MobOperationsView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.AutoSize = true;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.Controls.Add(this.listPanel);
         this.Margin = new System.Windows.Forms.Padding(0);
         this.Name = "MobOperationsView";
         this.Size = new System.Drawing.Size(595, 64);
         this.listPanel.ResumeLayout(false);
         this.listPanel.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.FlowLayoutPanel listPanel;
      private MobOperationView dummyMobOperationView1;
      private MobOperationView dummyMobOperationView2;
      private MobOperationView mobOperationView1;
      private MobOperationView mobOperationView2;
   }
}
