using System;

namespace _02.LinkedList
{
    public class CustomDynamicList<T>
    {
        private class ListNode
        {
            public T Element { get; set; }
            public ListNode NextNode { get; set; }

            public ListNode(T element)
            {
                this.Element = element;
                NextNode = null;
            }

            public ListNode(T element, ListNode previousNode)
            {
                this.Element = element;
                previousNode.NextNode = this;
            }
        }

        private ListNode head;
        private ListNode tail;
        private int count;
        public CustomDynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public int  Count { get { return this.count; } }

        // We need property wich will allow us to iterate trough collection -> to get or to set element at specified position
        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index " + index);
                }
                ListNode currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }
                return currentNode.Element;
            }

            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index " + index);
                }
                ListNode currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }
                currentNode.Element = value;
            }
        }

        public void Add(T element)
        {
            if (this.head == null)
            {
                // We have an empty list and we need to create new head and tail
                this.head = new ListNode(element);
                this.tail = this.head;
            }
            else
            {
                // We have a non-empty list so we must add the new element to the tail
                ListNode newListNode = new ListNode(element, this.tail);
                this.tail = newListNode;
            }

            this.count++;
        }

        public T RemoveAt(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index" + index);
            }
            // Find element at specified index
            int currentIndex = 0;
            ListNode currentNode = this.head;
            ListNode prevNode = null;

            while (currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }
            // When we find the index of the element next step is to remove it
            RemoveListNode(currentNode, prevNode);

            return currentNode.Element;
        }

        // We need to care about few things
        // 1. After removeal the whole list become empty => head = null; tail = null; count = 0;
        // 2. The element for removal is at the start of the list = > we make head to point element immediatly after the removed element
        // 3. Element is in the middle or at the end of the list => make sure that element before it point to the element after it
        private void RemoveListNode(ListNode currentNode, ListNode prevNode)
        {
            count--;
            if (count == 0)
            {
                // The list become empty so we need to remove head and tail
                this.head = null;
                this.tail = null;
            }
            else if (prevNode == null)
            {
                // The head node is removed so we need to update the head
                this.head = currentNode.NextNode;
            }
            else
            {
                // Redirect the pointers to be able to skip the removed element
                prevNode.NextNode = currentNode.NextNode;
            }
            // In case the tail is removed we need to fix it
            if (object.ReferenceEquals(this.tail, currentNode))
            {
                this.tail = prevNode;
            }
        }

        public int Remove(T element)
        {
            // Find element
            int currentIndex = 0;
            ListNode currentNode = this.head;
            ListNode prevNode = null;

            while (currentNode != null)
            {
                if (object.Equals(currentNode.Element, element))
                {
                    break;
                }

                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            if (currentNode != null)
            {
                // Element is found so remove it
                RemoveListNode(currentNode, prevNode);
                return currentIndex;
            }
            else
            {
                // Element is not found -> return -1
                return -1;
            }
        }

        public int IndexOf(T element)
        {
            int index = 0;
            ListNode currentNode = this.head;
            while (currentNode != null)
            {
                if (object.Equals(currentNode.Element, element))
                {
                    return index;
                }
                currentNode = currentNode.NextNode;
                index++;
            }

            return -1;
        }

        public bool Contains(T element)
        {
            int index = IndexOf(element);
            bool found = (index != -1);
            return found;
        }

    }
}
