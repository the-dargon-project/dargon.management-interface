namespace Dargon.Management.ViewModels {
   public class MobOperationViewModel {
      private readonly string name;
      private readonly MobOperationParameterViewModel[] parameterViewModels;
      private readonly int returnPofTypeId;

      public MobOperationViewModel(string name, MobOperationParameterViewModel[] parameterViewModels, int returnPofTypeId) {
         this.name = name;
         this.parameterViewModels = parameterViewModels;
         this.returnPofTypeId = returnPofTypeId;
      }

      public string Name { get { return name; } }
      public MobOperationParameterViewModel[] ParameterViewModels { get { return parameterViewModels; } }
      public int ReturnPofTypeId { get { return returnPofTypeId; } }
   }
}
