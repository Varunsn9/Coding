using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.CSharpCollection
{
    public class DictionaryCollection
    {
        public static void main(String[] args)
        {
            var d = new Dictionary<int, string>();
            d.Add(1, "varun");
            d.Add(2, "yusuf");
            d.Add(3, "suraj");
            d.Add(4, "niranjan");
            foreach (var item in d)
            {
                Console.WriteLine(item);
            }
            foreach(KeyValuePair<int,string> kv in d)
            {
                Console.WriteLine(kv.Key+" "+kv.Value);
            }
        }
    }
}
