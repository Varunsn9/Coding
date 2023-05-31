using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Generic_Collection
{
    internal class DictionaryFromGenericCollection
    {
        public static void main()
        {
            Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();
            keyValuePairs.Add(5, "friday");
            keyValuePairs.Add(2, "tuesday");
            keyValuePairs.Add(3, "wednesday");
            keyValuePairs.Add(4, "Thursday");
            keyValuePairs.Add(6, "saturday");
            keyValuePairs.Add(1, "monday");
            keyValuePairs.Add(7, "sunday");

            /*
            Console.WriteLine(keyValuePairs[1]);
            Console.WriteLine(keyValuePairs[3]);
            */
            foreach (KeyValuePair<int, string> kvp in keyValuePairs)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
