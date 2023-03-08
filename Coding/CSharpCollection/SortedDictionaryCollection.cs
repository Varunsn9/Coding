using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.CSharpCollection
{
    public class SortedDictionaryCollection
    {
        public static void ain(String[] args)
        {
            var sd = new SortedDictionary<int, string>();
            sd.Add(1, "beta ");
            sd.Add(5, "alpha");
            sd.Add(3, "gamma");
            foreach(var item in sd)
            {
                Console.WriteLine(item);
            }

            foreach(KeyValuePair<int,string> kv in sd)
            {
                Console.WriteLine(kv.Key + " "+kv.Value);
            }

        }
    }
}
