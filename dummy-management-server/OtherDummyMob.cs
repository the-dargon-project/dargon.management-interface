using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dargon.Management;

namespace Dargon.SomethingElse {
   public class OtherDummyMob {
      [ManagedOperation]
      public string HelloWorld() {
         return "Hello, World!";
      }
   }
}
