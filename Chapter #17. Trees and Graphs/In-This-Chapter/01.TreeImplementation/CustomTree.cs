using System;

namespace _01.TreeImplementation
{
    public class CustomTree<T>
    {
        // 1. Fields
        //========================================================================
        // The root of the tree
        private CustomTreeNode<T> rootElement;
        //========================================================================

        // 2. Constructor
        //========================================================================
        public CustomTree(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Can't insert null value!");
            }
            this.rootElement = new CustomTreeNode<T>(element);
        }

        public CustomTree(T element, params CustomTree<T>[] childrens)
            : this(element)
        {
            foreach (var child in childrens)
            {
                this.rootElement.AddChild(child.rootElement);
            }
        }
        //========================================================================

        // 3. Properties
        //========================================================================
        public CustomTreeNode<T> Root
        {
            get
            {
                return this.rootElement;
            }
        }
        //========================================================================

        // 4. Methods
        //========================================================================
        private void PrintDFS(CustomTreeNode<T> root, string spaces)
        {
            if (this.rootElement == null)
            {
                return;
            }
            Console.WriteLine("{0}|{1,3}|", spaces, root.Value);
            CustomTreeNode<T> child = null;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                PrintDFS(child, spaces + "    ");
            }
        }
        public void TraverseDFS()
        {
            this.PrintDFS(this.rootElement, String.Empty);
        }
        //========================================================================
        //========================================================================

    }

}
