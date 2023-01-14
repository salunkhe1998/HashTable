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
            Console.WriteLine("***** Welcome to Hashtable Program *****");
            Linked_Hash_Map<string, int> linked_hash_map = new Linked_Hash_Map<string, int>(5);

            string Sentence = "paranoids are not paranoid because they are paranoid but because " +
                "they keep putting themselves deliberately into paranoid avoidable situations";
            string[] Words = Sentence.Split(" ");
            Console.Write("Enter the word you want to omit: ");
            string Banned_Word = Console.ReadLine();
            foreach (string word in Words)
            {
                if (word != Banned_Word)
                {
                    int Value = linked_hash_map.Get(word);
                    if (Value == default)
                        Value = 1;
                    else Value++;
                    linked_hash_map.Add(word, Value);
                }
            }
            int Frequency = linked_hash_map.Get(Banned_Word);
            Console.WriteLine("\n\"{0}\" comes {1} times in the given paragraph now",
                Banned_Word, Frequency);
            Console.WriteLine("\nResulting paragraph:\n" + linked_hash_map.Result);
        }
    }

}