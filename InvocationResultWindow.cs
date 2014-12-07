using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dargon.Management {
   public partial class InvocationResultWindow : Form {
      public InvocationResultWindow(string text) {
         InitializeComponent();
         contentLabel.Text = text;
         okayButton.Click += (s, e) => Close();
      }
   }
}
