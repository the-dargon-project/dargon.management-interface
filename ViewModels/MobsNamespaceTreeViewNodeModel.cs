namespace Dargon.Management.ViewModels {
   class MobsNamespaceTreeViewNodeModel : MobsTreeViewNodeModel {
      private readonly string text;

      public MobsNamespaceTreeViewNodeModel(string text) {
         this.text = text;
      }

      public override string Text { get { return text; } }
      public override MobsTreeViewNodeType NodeType { get { return MobsTreeViewNodeType.Namespace; } }
      public override void HandleEnterRequest() { }
      public override bool IsTerminalNode { get { return false; } }
   }
}