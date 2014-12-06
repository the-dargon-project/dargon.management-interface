namespace Dargon.Management.ViewModels {
   public class MobOperationParameterViewModel {
      private readonly string name;
      private readonly int pofTypeId;
      private object value;

      public MobOperationParameterViewModel(string name, int pofTypeId) {
         this.name = name;
         this.pofTypeId = pofTypeId;
      }

      public string Name { get { return name; } }
      public int PofTypeId { get { return pofTypeId; } }
      public object Value { get { return value; } set { this.value = value; } }
   }
}
