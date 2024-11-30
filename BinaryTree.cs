using System;

namespace EstruturaAULA.Quiz
{
    // Classe para representar um nó da árvore
    public class TreeNode<T> where T : IComparable
    {
        public T Value { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    // Classe para a árvore binária
    public class BinaryTree<T> where T : IComparable
    {
        private TreeNode<T> root;

        public BinaryTree()
        {
            root = null;
        }

        // Método para inserir um valor na árvore
        public void Insert(T value)
        {
            root = InsertRecursively(root, value);
        }

        private TreeNode<T> InsertRecursively(TreeNode<T> node, T value)
        {
            if (node == null)
                return new TreeNode<T>(value);

            if (value.CompareTo(node.Value) < 0)
                node.Left = InsertRecursively(node.Left, value);
            else if (value.CompareTo(node.Value) > 0)
                node.Right = InsertRecursively(node.Right, value);

            return node;
        }

        // Método para buscar um valor na árvore
        public bool Search(T value)
        {
            return SearchRecursively(root, value);
        }

        private bool SearchRecursively(TreeNode<T> node, T value)
        {
            if (node == null)
                return false;

            if (value.CompareTo(node.Value) == 0)
                return true;

            if (value.CompareTo(node.Value) < 0)
                return SearchRecursively(node.Left, value);
            else
                return SearchRecursively(node.Right, value);
        }

        // Método para imprimir a árvore em ordem
        public void PrintInOrder()
        {
            PrintInOrderRecursively(root);
            Console.WriteLine();
        }

        private void PrintInOrderRecursively(TreeNode<T> node)
        {
            if (node != null)
            {
                PrintInOrderRecursively(node.Left);
                Console.Write(node.Value + " ");
                PrintInOrderRecursively(node.Right);
            }
        }
    }
}
