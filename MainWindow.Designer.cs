namespace Dargon.Management {
   partial class MainWindow {
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
         this.tabs = new System.Windows.Forms.TabControl();
         this.mobsTab = new System.Windows.Forms.TabPage();
         this.mobsPanel = new Dargon.Management.Views.MobsPanel();
         this.tabs.SuspendLayout();
         this.mobsTab.SuspendLayout();
         this.SuspendLayout();
         // 
         // tabs
         // 
         this.tabs.Controls.Add(this.mobsTab);
         this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabs.Location = new System.Drawing.Point(0, 0);
         this.tabs.Name = "tabs";
         this.tabs.SelectedIndex = 0;
         this.tabs.Size = new System.Drawing.Size(909, 539);
         this.tabs.TabIndex = 0;
         // 
         // mobsTab
         // 
         this.mobsTab.Controls.Add(this.mobsPanel);
         this.mobsTab.Location = new System.Drawing.Point(4, 22);
         this.mobsTab.Name = "mobsTab";
         this.mobsTab.Padding = new System.Windows.Forms.Padding(3);
         this.mobsTab.Size = new System.Drawing.Size(901, 513);
         this.mobsTab.TabIndex = 0;
         this.mobsTab.Text = "Management Objects";
         this.mobsTab.UseVisualStyleBackColor = true;
         // 
         // mobsPanel
         // 
         this.mobsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.mobsPanel.Location = new System.Drawing.Point(3, 3);
         this.mobsPanel.Name = "mobsPanel";
         this.mobsPanel.Size = new System.Drawing.Size(895, 507);
         this.mobsPanel.TabIndex = 0;
         // 
         // MainWindow
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(909, 539);
         this.Controls.Add(this.tabs);
         this.Name = "MainWindow";
         this.Text = "Dargon Management Interface";
         this.tabs.ResumeLayout(false);
         this.mobsTab.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl tabs;
      private System.Windows.Forms.TabPage mobsTab;
      private Views.MobsPanel mobsPanel;
   }
}