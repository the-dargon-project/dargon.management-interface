namespace Dargon.Management {
   partial class InvocationResultWindow {
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
         this.wrapper = new System.Windows.Forms.TableLayoutPanel();
         this.contentLabel = new System.Windows.Forms.Label();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.formActions = new System.Windows.Forms.FlowLayoutPanel();
         this.okayButton = new System.Windows.Forms.Button();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.tableLayoutPanel1.SuspendLayout();
         this.formActions.SuspendLayout();
         this.tableLayoutPanel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // wrapper
         // 
         this.wrapper.AutoSize = true;
         this.wrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.wrapper.ColumnCount = 1;
         this.wrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.wrapper.Location = new System.Drawing.Point(47, 32);
         this.wrapper.Margin = new System.Windows.Forms.Padding(0);
         this.wrapper.Name = "wrapper";
         this.wrapper.RowCount = 1;
         this.wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.wrapper.Size = new System.Drawing.Size(0, 0);
         this.wrapper.TabIndex = 3;
         // 
         // contentLabel
         // 
         this.contentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.contentLabel.AutoSize = true;
         this.contentLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
         this.contentLabel.ForeColor = System.Drawing.SystemColors.GrayText;
         this.contentLabel.Location = new System.Drawing.Point(0, 0);
         this.contentLabel.Margin = new System.Windows.Forms.Padding(0);
         this.contentLabel.Name = "contentLabel";
         this.contentLabel.Size = new System.Drawing.Size(394, 21);
         this.contentLabel.TabIndex = 1;
         this.contentLabel.Text = "Return Value. Return Value. Return Value. Return Value.";
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.AutoSize = true;
         this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.tableLayoutPanel1.ColumnCount = 1;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 2;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 100);
         this.tableLayoutPanel1.TabIndex = 6;
         // 
         // formActions
         // 
         this.formActions.Anchor = System.Windows.Forms.AnchorStyles.Top;
         this.formActions.AutoSize = true;
         this.formActions.Controls.Add(this.okayButton);
         this.formActions.Location = new System.Drawing.Point(159, 31);
         this.formActions.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
         this.formActions.Name = "formActions";
         this.formActions.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
         this.formActions.Size = new System.Drawing.Size(75, 26);
         this.formActions.TabIndex = 3;
         // 
         // okayButton
         // 
         this.okayButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.okayButton.Location = new System.Drawing.Point(0, 3);
         this.okayButton.Margin = new System.Windows.Forms.Padding(0);
         this.okayButton.Name = "okayButton";
         this.okayButton.Size = new System.Drawing.Size(75, 23);
         this.okayButton.TabIndex = 6;
         this.okayButton.Text = "Ok";
         this.okayButton.UseVisualStyleBackColor = true;
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel2.AutoSize = true;
         this.tableLayoutPanel2.ColumnCount = 1;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel2.Controls.Add(this.contentLabel, 0, 0);
         this.tableLayoutPanel2.Controls.Add(this.formActions, 0, 1);
         this.tableLayoutPanel2.Location = new System.Drawing.Point(25, 20);
         this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(25, 20, 25, 20);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 2;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 60);
         this.tableLayoutPanel2.TabIndex = 5;
         // 
         // InvocationResultWindow
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.ClientSize = new System.Drawing.Size(662, 246);
         this.Controls.Add(this.tableLayoutPanel1);
         this.Controls.Add(this.wrapper);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MinimumSize = new System.Drawing.Size(1, 1);
         this.Name = "InvocationResultWindow";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Result";
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.formActions.ResumeLayout(false);
         this.tableLayoutPanel2.ResumeLayout(false);
         this.tableLayoutPanel2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel wrapper;
      private System.Windows.Forms.Label contentLabel;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      private System.Windows.Forms.FlowLayoutPanel formActions;
      private System.Windows.Forms.Button okayButton;
   }
}