namespace Dargon.Management.Views {
   partial class MobView {
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
         this.tabs = new System.Windows.Forms.TabControl();
         this.operationsTab = new System.Windows.Forms.TabPage();
         this.mobOperationsView = new Dargon.Management.Views.MobOperationsView();
         this.tabs.SuspendLayout();
         this.operationsTab.SuspendLayout();
         this.SuspendLayout();
         // 
         // tabs
         // 
         this.tabs.Controls.Add(this.operationsTab);
         this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabs.Location = new System.Drawing.Point(0, 0);
         this.tabs.Name = "tabs";
         this.tabs.SelectedIndex = 0;
         this.tabs.Size = new System.Drawing.Size(469, 315);
         this.tabs.TabIndex = 0;
         // 
         // operationsTab
         // 
         this.operationsTab.Controls.Add(this.mobOperationsView);
         this.operationsTab.Location = new System.Drawing.Point(4, 22);
         this.operationsTab.Name = "operationsTab";
         this.operationsTab.Padding = new System.Windows.Forms.Padding(3);
         this.operationsTab.Size = new System.Drawing.Size(461, 289);
         this.operationsTab.TabIndex = 0;
         this.operationsTab.Text = "Operations";
         this.operationsTab.UseVisualStyleBackColor = true;
         // 
         // mobOperationsView
         // 
         this.mobOperationsView.AutoScroll = true;
         this.mobOperationsView.AutoSize = true;
         this.mobOperationsView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.mobOperationsView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.mobOperationsView.Location = new System.Drawing.Point(3, 3);
         this.mobOperationsView.Margin = new System.Windows.Forms.Padding(0);
         this.mobOperationsView.Name = "mobOperationsView";
         this.mobOperationsView.Size = new System.Drawing.Size(455, 283);
         this.mobOperationsView.TabIndex = 0;
         // 
         // MobView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.tabs);
         this.Name = "MobView";
         this.Size = new System.Drawing.Size(469, 315);
         this.tabs.ResumeLayout(false);
         this.operationsTab.ResumeLayout(false);
         this.operationsTab.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl tabs;
      private System.Windows.Forms.TabPage operationsTab;
      private MobOperationsView mobOperationsView;
   }
}
