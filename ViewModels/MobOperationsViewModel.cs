using Dargon.Management.Client;
using ItzWarty;
using System;
using System.Collections.Generic;
using System.Linq;
using ItzWarty.Comparers;

namespace Dargon.Management.ViewModels {
   public class MobOperationsViewModel {
      public event EventHandler Updated;
      private MobOperationViewModel[] operations;

      public MobOperationViewModel[] Operations { get { return operations; } }

      public void Update(IReadOnlyList<IRemoteMobOperationDescription> operations) {
         MobOperationViewModel[] viewModels = new MobOperationViewModel[operations.Count];
         for (var i = 0; i < operations.Count; i++) {
            viewModels[i] = CreateMobOperationModel(operations[i]);
         }
         this.operations = viewModels;
         OnUpdated();
      }

      private MobOperationViewModel CreateMobOperationModel(IRemoteMobOperationDescription op) {
         var parameterModels = Util.Generate(op.Parameters.Count, i => CreateMobOperationParameterModel(op.Parameters[i]));
         return new MobOperationViewModel(op.Name, parameterModels, op.ReturnPofTypeId);
      }

      private MobOperationParameterViewModel CreateMobOperationParameterModel(IRemoteMobOperationParameter p) {
         return new MobOperationParameterViewModel(p.Name, p.PofTypeId);
      }

      protected virtual void OnUpdated() {
         var capture = Updated;
         if (capture != null) {
            capture(this, EventArgs.Empty);
         }
      }
   }
}
