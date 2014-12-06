using ItzWarty;
using System.Collections.Generic;

namespace Dargon.Management.ViewModels {
   public abstract class MobsTreeViewNodeModel {
      private Dictionary<string, MobsTreeViewNodeModel> childNodesByName = new Dictionary<string, MobsTreeViewNodeModel>();
      private MobsTreeViewNodeModel parent;

      protected MobsTreeViewNodeModel() {

      }

      public abstract string Text { get; }
      public abstract MobsTreeViewNodeType NodeType { get; }
      public abstract void HandleEnterRequest();

      public abstract bool IsTerminalNode { get; }

      public MobsTreeViewNodeModel GetChildOrNull(string text) {
         return childNodesByName.GetValueOrDefault(FormatKey(text));
      }

      public void AddChild(MobsTreeViewNodeModel nodeModel) {
         childNodesByName.Add(FormatKey(nodeModel.Text), nodeModel);
         nodeModel.Parent = this;
      }

      public MobsTreeViewNodeModel Parent { get { return parent; } set { parent = value; } }

      private string FormatKey(string key) {
         return key.ToLower();
      }
   }
}
