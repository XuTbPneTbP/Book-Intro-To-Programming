using System;
using System.Collections;
using System.Collections.Generic;

namespace _02.DoubleLinkedList
{
    public class CustomDoubleLinked<T> : IEnumerable<T>
    {
        // =======================================================
        private class DoubleLinkedListNode
        {
            public T Value { get; set; }
            public DoubleLinkedListNode NextNode { get; set; }
            public DoubleLinkedListNode PreviousNode { get; set; }

            public DoubleLinkedListNode(T element)
            {
                this.Value = element;
                NextNode = null;
                PreviousNode = null;
            }

            public DoubleLinkedListNode(T element, DoubleLinkedListNode prevNode)
            {
                this.Value = element;
                this.NextNode = null;
                this.PreviousNode = prevNode;
                prevNode.NextNode = this;
            }
        }
        // =======================================================
        private DoubleLinkedListNode head;
        private DoubleLinkedListNode tail;
        private int count;
        public CustomDoubleLinked()
        {
            this.head = this.tail = null;
            this.count = 0;
        }
        public int Count { get { return this.count; } }
        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index!" + index);
                }
                DoubleLinkedListNode currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }
                return currentNode.Value;
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw  new ArgumentOutOfRangeException("Invalid index!" + index);
                }
                DoubleLinkedListNode currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }
                currentNode.Value = value;
            }
        }
        // =======================================================
        public void Add(T element)
        {
            if (this.head == null)
            {
                this.head = new DoubleLinkedListNode(element);
                this.tail = head;
            }
            else
            {
                DoubleLinkedListNode newNode = new DoubleLinkedListNode(element, this.tail);
                this.tail = newNode;
            }
            this.count++;
        }
        public void AddRange(T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (this.head == null)
                {
                    this.head = new DoubleLinkedListNode(elements[i]);
                    this.tail = head;
                }
                else
                {
                    DoubleLinkedListNode newNode = new DoubleLinkedListNode(elements[i], this.tail);
                    this.tail = newNode;
                }
                this.count++;
            }
        }
        public T RemoveAt(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index!" + index);
            }

            // Finde element at specified index
            int currentIndex = 0;
            DoubleLinkedListNode currentNode = this.head;
            DoubleLinkedListNode prevNode = null;
            while (currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }
            RemoveDoubleLinekdListNode(currentNode, prevNode);

            return currentNode.Value;
        }
        public int Remove(T element)
        {
            int currentIndex = 0;
            DoubleLinkedListNode currentNode = this.head;
            DoubleLinkedListNode prevNode = null;
            while (currentNode != null)
            {
                if (object.Equals(currentNode.Value, element))
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
                RemoveDoubleLinekdListNode(currentNode, prevNode);
                return currentIndex;
            }
            else
            {
                return -1;
            }
        }
        // =======================================================
        private void RemoveDoubleLinekdListNode(DoubleLinkedListNode currentNode, DoubleLinkedListNode prevNode)
        {
            this.count--;
            // The list become empty so we need to remove head and tail
            if (count == 0)
            {
                this.head = null;
                this.tail = null;
            }
            // Head node is removed so we need to update the head
            else if (prevNode == null)
            {
                this.head = currentNode.NextNode;
            }
            // Redirect the pointers
            else
            {
                prevNode.NextNode = currentNode.NextNode;
            }
            // In case the tail is removed we need to fix it
            if (object.ReferenceEquals(this.tail, currentNode))
            {
                this.tail = prevNode;
            }
        }
        public T[] ToArray()
        {
            var arr = new T[this.count];
            int index = 0;
            var currentNode = this.head;
            while (currentNode != null)
            {
                arr[index] = currentNode.Value;
                currentNode = currentNode.NextNode;
                index++;
            }
            return arr;
        }
        // =======================================================
        public void ForEach(Action<T> action)
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        // =======================================================
    }
}
