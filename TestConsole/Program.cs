using System.Collections.Generic;
using System.Linq;

namespace TestConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //evelOrder(TreeNode.CreatFakeTree());

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(TreeNode.CreatFakeTree());
            while (queue.Any()) {
            }
        }

        public static  IList<IList<int>> LevelOrder(TreeNode root)
        {
            lists = new List<IList<int>>();
            list = new List<int>();
            GetNode(root);
            return lists;
        }
        static  List<int> list;
        static  IList<IList<int>> lists;
        public static  void GetNode(TreeNode root)
        {
            if (root == null)
                return;
            list.Add(root.Value);
            lists.Add(list);
            GetNode(root.Left);
            GetNode(root.Right);
        }

    }

    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;
        public static TreeNode CreatFakeTree()
        {
            TreeNode tree = new TreeNode() { Value = 1 };
            tree.Left = new TreeNode()
            {
                Value = 2,
                Left = new TreeNode() { Value = 3, Left = new TreeNode() { Value = 6 } },
                Right = new TreeNode() { Value = 4, Right = new TreeNode() { Value = 7 } }
            };
            tree.Right = new TreeNode() { Value = 5, Right = new TreeNode() { Value = 8} };

            return tree;
        }
    }
}
