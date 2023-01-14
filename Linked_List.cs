using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAssignment
{
    public class Linked_List<K, V> where K : IComparable
    {
        public Hash_Node<K, V> Head;
        public Hash_Node<K, V> Tail;

        public Linked_List()
        {
            Head = null;
            Tail = null;
        }
        internal Hash_Node<K, V> Search(K Key)
        {
            Hash_Node<K, V> temp = Head;
            while (temp != null)
            {
                if (temp.Key.Equals(Key))
                {
                    return temp;
                }
                temp = temp.Next;
            }
            return null;
        }
        public void Append(Hash_Node<K, V> node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }
    }
}