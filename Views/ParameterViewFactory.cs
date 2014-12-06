﻿using Dargon.Management.ViewModels;
using Dargon.PortableObjects;
using System.Windows.Forms;

namespace Dargon.Management.Views {
   public class ParameterViewFactory {
      public UserControl CreateView(MobOperationParameterViewModel viewModel) {
         switch ((ReservedTypeId)viewModel.PofTypeId) {
            case ReservedTypeId.TYPE_STRING:
               return new MobStringParameterValueView(viewModel);
            case ReservedTypeId.TYPE_S32:
               return new MobInt32ParameterValueView(viewModel);
            default:
               return new MobUnsupportedParameterValueView();
         }
      }
   }
}