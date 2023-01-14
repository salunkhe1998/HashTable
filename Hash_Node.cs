using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAssignment
{
    public class Hash_Node<K, V>
    {
        public K Key;
        public V Value;
        public Hash_Node<K, V> Next;

        public Hash_Node(K Key, V Value)
        {
            this.Key = Key;
            this.Value = Value;
            Next = null;
        }
    }
}