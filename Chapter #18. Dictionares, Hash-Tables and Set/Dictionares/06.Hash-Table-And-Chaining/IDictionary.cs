using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Hash_Table_And_Chaining
{
    public interface IDictionary<K, V> : IEnumerable<KeyValuePair<K, V>>
    {
        V Get(K key);
        V Set(K key, V value);
        V this[K key] { get; set; }
        bool Remove(K key);
        int Count { get; }
        void Clear();
    }
}
