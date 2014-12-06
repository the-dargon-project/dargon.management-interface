using System;
using Dargon.Management.ViewModels;

namespace Dargon.Management.Controllers {
   public interface IMobsController {
      event InvocationResultEventHandler InvocationResult;
      MobsRootViewModel RootViewModel { get; }
      MobsTreeViewModel TreeViewModel { get; }
      void Initialize();
      void DisplayMob(Guid mobGuid);
      void Invoke(Guid mobGuid, MobOperationViewModel operationViewModel);
      string GetPofTypeIdName(int returnPofTypeId);
   }

   public delegate void InvocationResultEventHandler(IMobsController sender, object result);
}