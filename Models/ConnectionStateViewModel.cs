using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Dargon.Management.Models {
   public class ConnectionStateViewModel : INotifyPropertyChanged {
      public event PropertyChangedEventHandler PropertyChanged;
      private string destination;

      public string Destination { get { return destination; } set { destination = value; OnPropertyChanged(); } }

      protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
         var capture = PropertyChanged;
         if (capture != null) {
            capture(this, new PropertyChangedEventArgs(propertyName));
         }
      }
   }
}
