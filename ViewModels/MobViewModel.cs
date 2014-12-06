using System;

namespace Dargon.Management.ViewModels {
   public class MobViewModel {
      private readonly Guid guid;
      private MobOperationsViewModel operations = new MobOperationsViewModel();

      public MobViewModel(Guid guid) {
         this.guid = guid;
      }

      public Guid Guid { get { return guid; } }

      public MobOperationsViewModel Operations { get { return operations; } }
   }
}
