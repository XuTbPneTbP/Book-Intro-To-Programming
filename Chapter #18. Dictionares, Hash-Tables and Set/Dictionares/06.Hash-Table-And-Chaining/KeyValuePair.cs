using System.Text;

namespace _06.Hash_Table_And_Chaining
{
        public struct KeyValuePair<TKey, TValue>
        {
            public TKey Key { get; private set; }
            public TValue Value { get; private set; }

            public KeyValuePair(TKey key, TValue value)
                : this()
            {
                this.Key = key;
                this.Value = value;
            }

            public override string ToString()
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("[: ");
                if (this.Key != null)
                {
                    builder.Append(this.Key.ToString());
                }
                builder.Append(", ");
                if (this.Value != null)
                {
                    builder.Append(this.Value.ToString());
                }
                builder.Append(" :]");
                return builder.ToString();
            }

        }
}
