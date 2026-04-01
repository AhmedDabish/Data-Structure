using System;

namespace Data_Structure.Tree
{
    class BinaryTree
    {
        public TreeNode Root;

        public void InOrder()
        {
            InOrder(Root);
        }

        private void InOrder(TreeNode node)
        {
            if (node == null) return;
            InOrder(node.Left);
            Console.Write(node.Data + " ");
            InOrder(node.Right);
        }

        public void Insert(int data)
        {
            Root = InsertRec(Root, data);
        }

        private TreeNode InsertRec(TreeNode root, int data)
        {
            if (root == null)
                return new TreeNode(data);

            if (data < root.Data)
                root.Left = InsertRec(root.Left, data);
            else if (data > root.Data)
                root.Right = InsertRec(root.Right, data);

            return root;
        }

        public void PreOrder()
        {
            PreOrder(Root);
            Console.WriteLine();
        }

        private void PreOrder(TreeNode node)
        {
            if (node == null) return;
            Console.Write(node.Data + " ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void PostOrder()
        {
            PostOrder(Root);
            Console.WriteLine();
        }

        private void PostOrder(TreeNode node)
        {
            if (node == null) return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Data + " ");
        }
    }
}