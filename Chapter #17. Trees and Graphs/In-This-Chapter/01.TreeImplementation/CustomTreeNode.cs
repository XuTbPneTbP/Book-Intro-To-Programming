using System;
using System.Collections.Generic;

namespace _01.TreeImplementation
{
    public class CustomTreeNode<T>
    {
        // 1. Fields
        //========================================================================
        // Contains value of the node / element
        //  "Ivan, Dragan, Petkan"  string.Split(new char[]{' ', ','});
        // BigInteger number = 3336665374375356446757658769860000000;
        private T value;
        // Check whether the current node has parent or not
        private bool hasParent;
        // Contains children of the node
        private List<CustomTreeNode<T>> children;
        //========================================================================

        // 2. Constructor
        //========================================================================
        public CustomTreeNode(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Can't insert null value!");
            }
            this.value = element;
            this.children = new List<CustomTreeNode<T>>();
        }
        //========================================================================

        // 3. Properties
        //========================================================================
        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
        public int ChildrenCount
        {
            get
            {
                return this.children.Count;
            }
        }
        //========================================================================

        // 4. Methods
        //========================================================================
        public void AddChild(CustomTreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Can't insert null value!");
            }
            if (child.hasParent)
            {
                throw new ArgumentException("The node already has a parent!");
            }
            child.hasParent = true;
            this.children.Add(child);
        }
        public CustomTreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }
        //========================================================================
    }
}
