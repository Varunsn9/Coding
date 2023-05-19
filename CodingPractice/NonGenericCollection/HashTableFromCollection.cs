using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NonGenericCollection
{
    internal class HashTableFromCollection
    {
        public static void main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "monday");
            ht.Add(2, "tuesday");
            ht.Add(3, "wednesday");
           
            Console.WriteLine(ht[1]);//1 is a key
            Console.WriteLine( "=========================" );
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"{entry.Key}");
                Console.WriteLine($"{entry.Value}");
            }


        }
    }
}
