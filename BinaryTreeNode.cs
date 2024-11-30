using System.Collections.Generic;

namespace BinaryTree
{
    public class BinaryTreeNode<T>
    {
        public T Data { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public bool HasChildren() => Left != null || Right != null;
    }
}
