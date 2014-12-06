namespace Dargon.Management.ViewModels {
   public class MobsRootTreeViewNodeModel : MobsTreeViewNodeModel {
      public override string Text { get { return "Root"; } }
      public override MobsTreeViewNodeType NodeType { get { return MobsTreeViewNodeType.Root; } }
      public override void HandleEnterRequest() { }
      public override bool IsTerminalNode { get { return false; } }
   }
}