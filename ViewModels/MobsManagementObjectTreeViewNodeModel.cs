using Dargon.Management.Controllers;
using System;

namespace Dargon.Management.ViewModels {
   public class MobsManagementObjectTreeViewNodeModel : MobsTreeViewNodeModel {
      private readonly string name;
      private readonly Guid guid;
      private readonly IMobsController mobsController;

      public MobsManagementObjectTreeViewNodeModel(string name, Guid guid, IMobsController mobsController) {
         if (name == null) {
            throw new ArgumentNullException("name");
         }
         if (mobsController == null) {
            throw new ArgumentNullException("mobsController");
         }

         this.name = name;
         this.guid = guid;
         this.mobsController = mobsController;
      }

      public override string Text { get { return name; } }

      public override MobsTreeViewNodeType NodeType { get { return MobsTreeViewNodeType.ManagementObject; } }

      public override void HandleEnterRequest() {
         mobsController.DisplayMob(guid);
      }

      public override bool IsTerminalNode { get { return true; } }
   }
}