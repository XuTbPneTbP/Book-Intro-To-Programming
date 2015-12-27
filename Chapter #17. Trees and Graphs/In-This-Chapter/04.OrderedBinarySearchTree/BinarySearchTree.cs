using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OrderedBinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> root;

        public BinarySearchTree()
        {
            this.root = null;
        }
        //======================================================================
        public void Insert(T value)
        {
            this.root = Insert(value, null, root);
        }
        private BinaryTreeNode<T> Insert(T value, BinaryTreeNode<T> parentNode, BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                node = new BinaryTreeNode<T>(value);
                node.parent = parentNode;
            }
            else
            {
                int compareTo = value.CompareTo(node.value);
                if (compareTo < 0)
                {
                    node.leftChild = Insert(value, node, node.leftChild);
                }
                else if (compareTo > 0)
                {
                    node.rightChild = Insert(value, node, node.rightChild);
                }
            }
            return node;
        } 
        //======================================================================
        //======================================================================
        //======================================================================
        //======================================================================
        public void Traverse()
        {
            PrintDFS(this.root);
            Console.WriteLine();
        }
        private void PrintDFS(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            
            if (node != null)
            {
                PrintDFS(node.leftChild);
                Console.Write(" {0,3} ", node.value + "  ");
                PrintDFS(node.rightChild);
            }
        }

    }
}
