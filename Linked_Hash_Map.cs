using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAssignment
{
    public class Linked_Hash_Map<K, V> where K : IComparable
    {
        private readonly int Num_Buckets;
        readonly List<Linked_List<K, V>> Bucket_List;
        public StringBuilder Result;


        public Linked_Hash_Map(int Num_Buckets)
        {
            this.Num_Buckets = Num_Buckets;
            Bucket_List = new List<Linked_List<K, V>>(Num_Buckets);

            for (int i = 0; i < Num_Buckets; i++)
                Bucket_List.Add(null);
        }
        public V Get(K Key)
        {
            int Index = Get_Index(Key);
            Linked_List<K, V> linked_list = Bucket_List[Index];
            if (linked_list == null)
                return default;
            Hash_Node<K, V> hash_node = linked_list.Search(Key);
            return (hash_node == null) ? default : hash_node.Value;
        }
        public int Get_Index(K Key)
        {
            int Hash_Code = Math.Abs(Key.GetHashCode());
            int Index = Hash_Code % Num_Buckets;
            return Index;
        }
        public void Add(K Key, V Value)
        {
            int Index = Get_Index(Key);
            Linked_List<K, V> linked_list = Bucket_List[Index];

            if (linked_list == null)
            {
                linked_list = new Linked_List<K, V>();
                Bucket_List[Index] = linked_list;
            }
            Hash_Node<K, V> hash_node = linked_list.Search(Key);
            if (hash_node == null)
            {
                hash_node = new Hash_Node<K, V>(Key, Value);
                linked_list.Append(hash_node);
            }
            else hash_node.Value = Value;
        }

    }
}