namespace Dargon.Management.Views {
   partial class MobsPanel {
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
         this.splitContainer = new System.Windows.Forms.SplitContainer();
         this.mobsTreeView = new Dargon.Management.Views.MobsTreeView();
         this.mobView = new Dargon.Management.Views.MobView();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
         this.splitContainer.Panel1.SuspendLayout();
         this.splitContainer.Panel2.SuspendLayout();
         this.splitContainer.SuspendLayout();
         this.SuspendLayout();
         // 
         // splitContainer
         // 
         this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer.Location = new System.Drawing.Point(0, 0);
         this.splitContainer.Name = "splitContainer";
         // 
         // splitContainer.Panel1
         // 
         this.splitContainer.Panel1.Controls.Add(this.mobsTreeView);
         // 
         // splitContainer.Panel2
         // 
         this.splitContainer.Panel2.Controls.Add(this.mobView);
         this.splitContainer.Size = new System.Drawing.Size(885, 484);
         this.splitContainer.SplitterDistance = 294;
         this.splitContainer.TabIndex = 1;
         // 
         // mobsTreeView
         // 
         this.mobsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.mobsTreeView.Location = new System.Drawing.Point(0, 0);
         this.mobsTreeView.Name = "mobsTreeView";
         this.mobsTreeView.Size = new System.Drawing.Size(294, 484);
         this.mobsTreeView.TabIndex = 0;
         // 
         // mobView
         // 
         this.mobView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.mobView.Location = new System.Drawing.Point(0, 0);
         this.mobView.Name = "mobView";
         this.mobView.Size = new System.Drawing.Size(587, 484);
         this.mobView.TabIndex = 0;
         // 
         // MobsPanel
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.splitContainer);
         this.Name = "MobsPanel";
         this.Size = new System.Drawing.Size(885, 484);
         this.splitContainer.Panel1.ResumeLayout(false);
         this.splitContainer.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
         this.splitContainer.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.SplitContainer splitContainer;
      private MobView mobView;
      private MobsTreeView mobsTreeView;
   }
}
