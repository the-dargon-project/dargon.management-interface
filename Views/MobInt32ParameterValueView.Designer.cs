namespace Dargon.Management.Views {
   partial class MobInt32ParameterValueView {
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
         this.numericUpDown = new System.Windows.Forms.NumericUpDown();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
         this.SuspendLayout();
         // 
         // numericUpDown
         // 
         this.numericUpDown.Location = new System.Drawing.Point(0, 0);
         this.numericUpDown.Margin = new System.Windows.Forms.Padding(0);
         this.numericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
         this.numericUpDown.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
         this.numericUpDown.Name = "numericUpDown";
         this.numericUpDown.Size = new System.Drawing.Size(120, 20);
         this.numericUpDown.TabIndex = 1;
         // 
         // MobInt32ParameterValueView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.Controls.Add(this.numericUpDown);
         this.Name = "MobInt32ParameterValueView";
         this.Size = new System.Drawing.Size(120, 20);
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.NumericUpDown numericUpDown;
   }
}
