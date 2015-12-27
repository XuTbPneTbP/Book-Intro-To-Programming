using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _01.List_Implementation
{
    public class CustomArrayList<T>
    {
        private const int INITIAL_CAPACITY = 4;
        // 1. We define array where we will hold the data of the elements & counter for the current count of elemenst
        private T[] array;
        private int count;

        // 2. In order to avoid resizing when adding few elements we initialize in the constructor some default capacity
        public CustomArrayList(int capacity = INITIAL_CAPACITY)
        {
            this.array = new T[capacity];
            this.count = 0;
        }
        // Property Indexer wich allows us to iterate over collection with for-loop. This Indexer gives us ability to access elements for read and change only by their index
        public int Counter
        {
            get
            {
                return this.count;
            }
        }
        public T this[int index]
        {
            get
            {
                if (index >= this.count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index " + index);
                }
                return this.array[index];
            }
            set
            {
                if (index >= this.count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index " + index);
                }
                this.array[index] = value;
            }
        }

        // 3. We will implement few basics operations like Add => apend; Insert => at specified position (index) and Clear
        // = > Firstly, at implementing each operation we need to ensure that internal array has enough capacity. If full = > extendet to a double of the current capacity
        private void GrowIfFull()
        {
            if (this.count + 1 > this.array.Length)
            {
                // Create new array with double capacity
                T[] extendedArray = new T[this.array.Length * 2];
                // Copy the elements to the new array
                Array.Copy(this.array, extendedArray, this.count);
                // We set extended array back to our default
                this.array = extendedArray;
            }
        }

        public void Clear()
        {
            this.array = new T[INITIAL_CAPACITY];
            this.count = 0;
        }

        public void Add(T item)
        {
            GrowIfFull();
            this.array[this.count] = item;
            this.count++;
        }

        public void Insert(int index, T item)
        {
            // First we check if we are in the boundries of our array
            if (index > this.count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index " + index);
            }
            // Check the capacity
            GrowIfFull();
            // Now we can copy the values to specified index
            Array.Copy(this.array, index, this.array, index + 1, this.count - index);
            this.array[index] = item;
            this.count++;
        }

       public int IndexOf(T item)
        {
            // For this operation we need inplemented the property Indexer = > T this[int index]
            for (int i = 0; i < this.array.Length; i++)
            {
                if (object.Equals(item, this.array[i]))
                {
                    return i;
                }
            }
            return -1;
        }
     
        public bool Contains(T item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);
            return found;
        }

        public T RemoveAt(int index)
        {
            if (index >= this.count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index " + index);
            }

            T item = this.array[index];
            Array.Copy(this.array, index + 1, this.array, index, this.count - index - 1);
            this.array[this.count - 1] = default(T);
            this.count--;

            return item;
        }

        public int Remove(T item)
        {
            int index = IndexOf(item);
            if (index != -1)
            {
                this.RemoveAt(index);
            }
            return index;
        }

    }

}
