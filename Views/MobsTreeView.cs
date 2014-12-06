using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dargon.Management.Controllers;
using Dargon.Management.ViewModels;
using NLog;

namespace Dargon.Management.Views {
   public partial class MobsTreeView : UserControl {
      private static readonly Logger logger = LogManager.GetCurrentClassLogger();

      private IMobsController controller;
      private MobsTreeViewModel viewModel;
      private readonly Dictionary<MobsTreeViewNodeModel, TreeNode> viewNodesByViewModel = new Dictionary<MobsTreeViewNodeModel, TreeNode>();
      private readonly Dictionary<TreeNode, MobsTreeViewNodeModel> viewModelsByViewNode = new Dictionary<TreeNode, MobsTreeViewNodeModel>();

      public MobsTreeView() {
         InitializeComponent();
      }

      public void SetController(IMobsController controller) {
         this.controller = controller;
      }

      public void Initialize() {
         this.viewModel = controller.TreeViewModel;
         this.viewModel.NodeAdded += HandleViewModelNodeAdded;
         this.viewModel.NodeRemoved += HandleViewModelNodeRemoved;
         this.treeView.NodeMouseDoubleClick += HandleNodeMouseDoubleClicked;

         var rootNode = viewModel.Root;
         var rootNodeView = CreateAndRegisterNodeView(rootNode);
         this.treeView.Nodes.Add(rootNodeView);
      }

      private void HandleViewModelNodeAdded(MobsTreeViewModel sender, MobsTreeViewNodeModel nodeModel) {
         TreeNode parentNodeView;
         if (!viewNodesByViewModel.TryGetValue(nodeModel.Parent, out parentNodeView)) {
            logger.Error("Unable to find view node for node " + nodeModel.Parent);
         } else {
            var nodeView = CreateAndRegisterNodeView(nodeModel);
            BeginInvoke(new Action(() => {
               parentNodeView.Nodes.Add(nodeView);
               if (parentNodeView.Parent == null) {
                  parentNodeView.Expand();
               }
            }));
         }
      }

      private void HandleViewModelNodeRemoved(MobsTreeViewModel treeviewmodel, MobsTreeViewNodeModel treeviewnodemodel) {
         throw new NotImplementedException();
      }

      private void HandleNodeMouseDoubleClicked(object sender, TreeNodeMouseClickEventArgs e) {
         MobsTreeViewNodeModel viewModel;
         if (viewModelsByViewNode.TryGetValue(e.Node, out viewModel)) {
            viewModel.HandleEnterRequest();
         }
      }

      private TreeNode CreateAndRegisterNodeView(MobsTreeViewNodeModel node) {
         var nodeView = new TreeNode(node.Text);
         viewNodesByViewModel.Add(node, nodeView);
         viewModelsByViewNode.Add(nodeView, node);
         return nodeView;
      }
   }
}
