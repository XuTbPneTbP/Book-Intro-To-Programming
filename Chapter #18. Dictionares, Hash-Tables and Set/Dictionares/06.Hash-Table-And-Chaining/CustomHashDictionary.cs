using System;
using System.Collections;
using System.Collections.Generic;

namespace _06.Hash_Table_And_Chaining
{
    public class CustomHashDictionary<K, V> : IDictionary<K, V>
    {
        private const int DEFAULT_CAPACITY = 16;
        private const float DEFAULT_LOAD_FACTOR = 0.75f;
        private List<KeyValuePair<K, V>>[] table;
        private float loadfactor;
        private int threshold;
        private int size;
        private int initialCapacity;

        // Create empty hash table with default capacity and load factor
        public CustomHashDictionary()
            : this(DEFAULT_CAPACITY, DEFAULT_LOAD_FACTOR)
        { }

        public CustomHashDictionary(int capacity, float loadFactor)
        {
            this.initialCapacity = capacity;
            this.loadfactor = loadFactor;
            this.threshold = (int)(capacity * loadFactor);
            this.table = new List<KeyValuePair<K, V>>[capacity];
        }

        private List<KeyValuePair<K, V>> FindChain(K key, bool createIfMissing)
        {
            int index = key.GetHashCode();
            index = index & 0x7FFFFFFF; // clear the negative bits
            index = index%this.table.Length;
            if (this.table[index] == null && createIfMissing)
            {
                this.table[index] = new List<KeyValuePair<K, V>>();
            }
            return this.table[index] as List<KeyValuePair<K, V>>;
        }

        // Finds the value assignet to given key
        public V Get(K key)
        {
            List<KeyValuePair<K, V>> chain = this.FindChain(key, false);
            if (chain != null)
            {
                foreach (KeyValuePair<K, V>  entry in chain)
                {
                    if (entry.Key.Equals(key))
                    {
                        return entry.Value;
                    }
                }
            }

            return default(V);
        }

        // Assign value to certain key. If key exist its value is repraced. If doesnt exist it is firs created. return the old replaced value or null
        public V Set(K key, V value)
        {
            if (this.size >= this.threshold)
            {
               this.Expand();
            }

            List<KeyValuePair<K, V>> chain = this.FindChain(key, true);

            for (int i = 0; i < chain.Count; i++)
            {
                KeyValuePair<K,
                V > entry = chain[i];
                if (entry.Key.Equals(key))
                {
                    // The key is found = > replace its value with the new one
                    KeyValuePair<K, V> newEntry =
                        new KeyValuePair<K, V>(key, value);

                    chain[i] = newEntry;
                    return entry.Value;
                }
            }
            chain.Add(new KeyValuePair<K, V>(key, value));
            this.size++;

            return default(V);
        }

        // Gets/sets the value by given key. Get return null if the key is not found. Set replaces the existing value ot creates a new Key-Value pair if the key does not exist
        public V this[K key]
        {
            get { return this.Get(key); }
            set { this.Set(key, value); }
        }

        public bool Remove(K key)
        {
            List<KeyValuePair<K, V>> chain = this.FindChain(key, false);
            if (chain != null)
            {
                for (int i = 0; i < chain.Count; i++)
                {
                    KeyValuePair<K, V> entry = chain[i];
                    if (entry.Key.Equals(key))
                    {
                        // Key found => remove it
                        chain.RemoveAt(i);
                        this.size--;
                        return true;
                    }
                }
            }

            return false;
        }

        public int Count
        {
            get { return this.size; }
        }

        public void Clear()
        {
            this.table = new List<KeyValuePair<K, V>>[this.initialCapacity];
            this.size = 0;
        }

        private void Expand()
        {
            int newCapacity = 2*this.table.Length;
            List<KeyValuePair<K, V>>[] oldTable = this.table;
            this.table = new List<KeyValuePair<K, V>>[newCapacity];
            this.threshold = (int)(newCapacity * this.loadfactor);

            foreach (List<KeyValuePair<K, V>> oldChain in oldTable)
            {
                if (oldChain != null)
                {
                    foreach (KeyValuePair<K, V> keyValuePair in oldChain)
                    {
                        List<KeyValuePair<K, V>> chain = FindChain(keyValuePair.Key, true);
                        chain.Add(keyValuePair);
                    }
                }
            }

        }

        // Implement the IEnumerable<KeyValuePair<K, V>> allows us to iterate over the pairs with foreach-loop
        IEnumerator<KeyValuePair<K, V>> IEnumerable<KeyValuePair<K, V>>.GetEnumerator()
        {
            foreach (List<KeyValuePair<K, V>> chain in this.table)
            {
                if (chain != null)
                {
                    foreach (KeyValuePair<K, V> entry in chain)
                    {
                        yield return entry;
                    }
                }
            }

        }

       IEnumerator IEnumerable.GetEnumerator()
       {
           return ((IEnumerable<KeyValuePair<K, V>>) this).GetEnumerator();
       }

    }
}
