using Dargon.Management.ViewModels;
using Dargon.PortableObjects;
using System.Windows.Forms;

namespace Dargon.Management.Views {
   public class ParameterViewFactory {
      public UserControl CreateParameterView(MobOperationParameterViewModel viewModel) {
         return new MobParameterView(viewModel, CreateParameterValueView(viewModel));
      }

      private UserControl CreateParameterValueView(MobOperationParameterViewModel viewModel) {
         switch ((ReservedTypeId)viewModel.PofTypeId) {
            case ReservedTypeId.TYPE_STRING:
               return new MobStringParameterValueView(viewModel);
            case ReservedTypeId.TYPE_S32:
               return new MobInt32ParameterValueView(viewModel);
            case ReservedTypeId.TYPE_S64:
               return new MobInt64ParameterValueView(viewModel);
            default:
               return new MobUnsupportedParameterValueView();
         }
      }
   }
}
