namespace Dargon.Management.Views {
   partial class MobParameterView {
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
         this.parameterNameLabel = new System.Windows.Forms.Label();
         this.placeholderParameterView = new Dargon.Management.Views.MobStringParameterValueView();
         this.flowLayoutPanel.SuspendLayout();
         this.SuspendLayout();
         // 
         // flowLayoutPanel
         // 
         this.flowLayoutPanel.AutoSize = true;
         this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.flowLayoutPanel.Controls.Add(this.parameterNameLabel);
         this.flowLayoutPanel.Controls.Add(this.placeholderParameterView);
         this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
         this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
         this.flowLayoutPanel.Name = "flowLayoutPanel";
         this.flowLayoutPanel.Size = new System.Drawing.Size(185, 20);
         this.flowLayoutPanel.TabIndex = 0;
         // 
         // parameterNameLabel
         // 
         this.parameterNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.parameterNameLabel.AutoSize = true;
         this.parameterNameLabel.Location = new System.Drawing.Point(0, 3);
         this.parameterNameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
         this.parameterNameLabel.Name = "parameterNameLabel";
         this.parameterNameLabel.Size = new System.Drawing.Size(82, 13);
         this.parameterNameLabel.TabIndex = 0;
         this.parameterNameLabel.Text = "parameterName";
         this.parameterNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // placeholderParameterView
         // 
         this.placeholderParameterView.AutoSize = true;
         this.placeholderParameterView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.placeholderParameterView.Location = new System.Drawing.Point(85, 0);
         this.placeholderParameterView.Margin = new System.Windows.Forms.Padding(0);
         this.placeholderParameterView.Name = "placeholderParameterView";
         this.placeholderParameterView.Size = new System.Drawing.Size(100, 20);
         this.placeholderParameterView.TabIndex = 1;
         // 
         // MobParameterView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.Controls.Add(this.flowLayoutPanel);
         this.Margin = new System.Windows.Forms.Padding(0);
         this.Name = "MobParameterView";
         this.Size = new System.Drawing.Size(185, 20);
         this.flowLayoutPanel.ResumeLayout(false);
         this.flowLayoutPanel.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
      private System.Windows.Forms.Label parameterNameLabel;
      private MobStringParameterValueView placeholderParameterView;
   }
}
