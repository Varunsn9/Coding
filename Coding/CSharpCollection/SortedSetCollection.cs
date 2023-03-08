using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.CSharpCollection
{
    public class SortedSetCollection
    {
        public static void aain(String[] args)
        {
            var ss = new SortedSet<string>();
            ss.Add("z");
            ss.Add("y");
            ss.Add("z");
            ss.Add("y");
            ss.Add("z");
            ss.Add("y");
            ss.Add("z");
            ss.Add("y");
            foreach(var items in ss)
            {
                Console.WriteLine(items);
            }
        }
    }
}
