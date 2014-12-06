using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dargon.Management {
   public class HerpMob {
      [ManagedOperation]
      public string Derp() {
         return "Herp Derp.";
      }
   }
}
