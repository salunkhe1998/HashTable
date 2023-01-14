using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAssignment
{
    namespace HashTable
    {
        class Program
        {
            public static void Main(string[] args)
            {
                Linked_Hash_Map<string, int> linked_hash_map = new Linked_Hash_Map<string, int>(5);

                string Sentence = "to be or not to be";
                string[] Words = Sentence.Split(" ");
                foreach (string word in Words)
                {
                    int Value = linked_hash_map.Get(word);
                    if (Value == default)
                        Value = 1;
                    else Value++;
                    linked_hash_map.Add(word, Value);
                }
                int Frequency = linked_hash_map.Get("to");
                Console.WriteLine("Frquency of word in mentioned statement is : " + Frequency);
            }
        }
    }

}