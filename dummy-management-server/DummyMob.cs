namespace Dargon.Management {
   public class DummyMob {
      private int counter = 0;

      [ManagedOperation]
      public string SayHello(string name) {
         return "Hello, " + name + "!";
      }

      [ManagedOperation]
      public string SayGoodbye(string name) {
         return "Goodbye, " + name + "!";
      }

      [ManagedOperation]
      public int IncrementCounter() {
         return counter++;
      }
   }
}
