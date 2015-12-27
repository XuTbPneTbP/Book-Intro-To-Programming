using System;

namespace _03.BinaryTree
{
    public class BinaryTree<T>
    {
        // 1. Fields
        //========================================================================
        //========================================================================

        // 2. Constructor
        //========================================================================
        public BinaryTree(T value, BinaryTree<T> leftChild, BinaryTree<T> rightChild)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public BinaryTree(T value)
            : this(value, null, null)
        {
        }
        //========================================================================

        // 3. Properties
        //========================================================================
        public T Value { get; set; }
        public BinaryTree<T> LeftChild { get; private set; }
        public BinaryTree<T> RightChild { get; private set; }
        //========================================================================

        // 4. Methods
        //========================================================================
        public void PrintInOrder()
        {
            // Visit left child
            if (this.LeftChild != null)
            {
                this.LeftChild.PrintInOrder();
            }

            // Visit the root
            Console.WriteLine(this.Value + " ");

            // Visit right child
            if (this.RightChild != null)
            {
                this.RightChild.PrintInOrder();
            }
        }
        //========================================================================
        //========================================================================
        //========================================================================
        //========================================================================
    }
}
