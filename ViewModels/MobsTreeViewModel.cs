using Dargon.Management.Controllers;
using Dargon.Management.Models;
using ItzWarty;
using System.Linq;

namespace Dargon.Management.ViewModels {
   public class MobsTreeViewModel {
      public delegate void NodeAddedEventHandler(MobsTreeViewModel treeViewModel, MobsTreeViewNodeModel treeViewNodeModel);
      public delegate void NodeRemovedEventHandler(MobsTreeViewModel treeViewModel, MobsTreeViewNodeModel treeViewNodeModel);

      private readonly MobsTreeViewNodeModel root = new MobsRootTreeViewNodeModel();
      private IMobsController controller;
      public event NodeAddedEventHandler NodeAdded;
      public event NodeAddedEventHandler NodeRemoved;

      public void SetController(IMobsController controller) {
         this.controller = controller;
      }

      public MobsTreeViewNodeModel Root { get { return root; } }

      public void HandleMobAdded(MobModel mobModel) {
         var parts = mobModel.Name.Split(".");
         var terminalName = parts.Last();
         var breadcrumbsToTerminal = new[] { parts.SubArray(0, parts.Length - 1).Join(".") };
         //var breadcrumbsToTerminal = parts.SubArray(0, parts.Length - 1);
         var currentNode = root;
         foreach (var breadcrumb in breadcrumbsToTerminal) {
            var child = currentNode.GetChildOrNull(breadcrumb);
            if (child != null) {
               currentNode = child;
            } else {
               child = new MobsNamespaceTreeViewNodeModel(breadcrumb);
               currentNode.AddChild(child);
               OnNodeAdded(child);
               currentNode = child;
            }
         }
         var terminalNode = new MobsManagementObjectTreeViewNodeModel(terminalName, mobModel.Guid, controller);
         currentNode.AddChild(terminalNode);
         OnNodeAdded(terminalNode);
      }

      public void HandleMobRemoved(MobModel mobModel) {
         throw new System.NotImplementedException();
      }

      protected virtual void OnNodeAdded(MobsTreeViewNodeModel treeviewnodemodel) {
         var capture = NodeAdded;
         if (capture != null) {
            capture(this, treeviewnodemodel);
         }
      }

      protected virtual void OnNodeRemoved(MobsTreeViewNodeModel treeviewnodemodel) {
         var capture = NodeRemoved;
         if (capture != null) {
            capture(this, treeviewnodemodel);
         }
      }
   }
}
