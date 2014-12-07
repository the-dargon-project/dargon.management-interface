using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dargon.Management {
   public class ManagementInterfaceConfiguration {
      private string destination = null;

      public ManagementInterfaceConfiguration() {

      }

      public string Destination { get { return destination; } }

      public void SetDestination(string destination) {
         if (this.destination != null) {
            throw new InvalidOperationException("Unexpected destination token - destination already set.");
         } else {
            this.destination = destination;
         }
      }
   }
}
