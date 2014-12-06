using Dargon.Management.Client;
using Dargon.Management.Models;
using Dargon.Management.ViewModels;
using Dargon.PortableObjects;
using ItzWarty;
using NLog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dargon.Management.Controllers {
   public class MobsController : IMobsController {
      private static readonly Logger logger = LogManager.GetCurrentClassLogger();

      public event InvocationResultEventHandler InvocationResult;
      private readonly IManagementClient client;
      private readonly MobsRootViewModel mobsRootViewModel;
      private readonly IPofContext pofContext;
      private readonly MobsTreeViewModel mobsTreeViewModel;
      private readonly Dictionary<Guid, MobModel>  mobModelsByMobGuid = new Dictionary<Guid, MobModel>();
      private readonly object synchronization = new object();

      public MobsController(IManagementClient client, MobsRootViewModel mobsRootViewModel, IPofContext pofContext) {
         this.client = client;
         this.mobsRootViewModel = mobsRootViewModel;
         this.pofContext = pofContext;
         this.mobsTreeViewModel = mobsRootViewModel.TreeModel;
         this.mobsRootViewModel.SetController(this);
      }

      public MobsRootViewModel RootViewModel { get { return mobsRootViewModel; } }
      public MobsTreeViewModel TreeViewModel { get { return mobsTreeViewModel; } }

      public void Initialize() {
         client.RemoteManageableObjectAdded += HandleRemoteManageableObjectAdded;
         client.RemoteManageableObjectRemoved += HandleRemoteManageableObjectRemoved;
         client.RemoteManageableObjectOperationsResult += HandleRemoteManageableObjectOperationsResult;
         client.InvocationResult += HandleInvocationResult;
      }

      public void DisplayMob(Guid mobGuid) {
         logger.Info("Controller Action: DisplayMob " + mobGuid + ".");
         var viewModel = new MobViewModel(mobGuid);
         mobsRootViewModel.SetCurrentMobViewModel(viewModel);
         client.RequestMobOperations(mobGuid);
      }

      public void Invoke(Guid mobGuid, MobOperationViewModel operationViewModel) {
         logger.Info("Controller Action: Invoke " + mobGuid + ".");
         var parameterViewModels = operationViewModel.ParameterViewModels;
         var parameters = Util.Generate(parameterViewModels.Length, i => parameterViewModels[i].Value);
         client.RequestInvocation(mobGuid, operationViewModel.Name, parameters);
      }

      public string GetPofTypeIdName(int returnPofTypeId) {
         var type = pofContext.GetTypeOrNull(returnPofTypeId);
         if (type == null) {
            return "Unknown Type";
         } else {
            return type.FullName;
         }
      }

      internal void HandleRemoteManageableObjectAdded(IManagementClient client, IRemoteMobDescription description) {
         lock (synchronization) {
            var mobModel = new MobModel(description.Guid, description.Name);

            mobsTreeViewModel.HandleMobAdded(mobModel);
         }
      }

      internal void HandleRemoteManageableObjectRemoved(IManagementClient client, IRemoteMobDescription description) {
         lock (synchronization) {
            MobModel mobModel;
            if (mobModelsByMobGuid.TryGetValue(description.Guid, out mobModel)) {
               mobModelsByMobGuid.Remove(description.Guid);
               mobsTreeViewModel.HandleMobRemoved(mobModel);
            } else {
               logger.Error("Could not find mob model `{0}` of guid {1} for removal.".F(description.Name, description.Guid));
               throw new InvalidOperationException();
            }
         }
      }

      private void HandleRemoteManageableObjectOperationsResult(IManagementClient client, IRemoteMobOperationsDescription description) {
         lock (synchronization) {
            var currentMobViewModel = mobsRootViewModel.MobViewModel;
            if (description.Guid == currentMobViewModel.Guid) {
               currentMobViewModel.Operations.Update(description.Operations);
            }
         }
      }

      private void HandleInvocationResult(IManagementClient managementClient, object result) {
         var capture = InvocationResult;
         if (capture != null) {
            capture(this, result);
         }
      }
   }
}
