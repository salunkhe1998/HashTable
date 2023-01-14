using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hashtable Program");
            Linked_Hash_Map<string, int> linked_hash_map = new Linked_Hash_Map<string, int>(5);

            string Sentence = "paranoids are not paranoid because they are paranoid but because " +
                "they keep putting themselves deliberately into paranoid avoidable situations";
            string[] Words = Sentence.Split(" ");
            foreach (string word in Words)
            {
                int Value = linked_hash_map.Get(word);
                if (Value == default)
                    Value = 1;
                else Value++;
                linked_hash_map.Add(word, Value);
            }
            int Frequency = linked_hash_map.Get("paranoid");
            Console.WriteLine("\"paranoid\" comes {0} times in the given paragraph", Frequency);
            Frequency = linked_hash_map.Get("are");
            Console.WriteLine("\"are\" comes {0} times in the given paragraph", Frequency);
            Frequency = linked_hash_map.Get("they");
            Console.WriteLine("\"they\" comes {0} times in the given paragraph", Frequency);
        }
    }

}