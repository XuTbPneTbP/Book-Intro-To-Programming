using System;
using System.Data;

namespace _04.OrderedBinarySearchTree
{
    internal class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> where T : IComparable<T>
    {
        // 1. Fields
        //======================================================================
        internal T value;
        internal BinaryTreeNode<T> parent;
        internal BinaryTreeNode<T> leftChild;
        internal BinaryTreeNode<T> rightChild; 
        //======================================================================

        // 2. Constructor
        //======================================================================
        public BinaryTreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Null values cannot be compared!");
            }
            this.value = value;
            this.parent = null;
            this.leftChild = null;
            this.rightChild = null;
        }
        //======================================================================

        // 3. Methods
        //======================================================================
        public int CompareTo(BinaryTreeNode<T> other)
        {
            return this.value.CompareTo(other.value);
        }

        public override string ToString()
        {
            return this.value.ToString();
        }

        public override bool Equals(object obj)
        {
            BinaryTreeNode<T> other = (BinaryTreeNode<T>) obj;
            return this.CompareTo(other) == 0;
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        //======================================================================
        
    }
}
