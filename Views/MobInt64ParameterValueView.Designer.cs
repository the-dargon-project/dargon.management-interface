namespace Dargon.Management.Views {
   partial class MobInt64ParameterValueView {
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
         this.textBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // textBox
         // 
         this.textBox.Location = new System.Drawing.Point(0, 0);
         this.textBox.Margin = new System.Windows.Forms.Padding(0);
         this.textBox.Name = "textBox";
         this.textBox.Size = new System.Drawing.Size(137, 20);
         this.textBox.TabIndex = 2;
         // 
         // MobInt64ParameterValueView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.Controls.Add(this.textBox);
         this.Name = "MobInt64ParameterValueView";
         this.Size = new System.Drawing.Size(137, 20);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox textBox;
   }
}
