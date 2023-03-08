using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.CSharpCollection
{
    public class SortedListCollection
    {
        public static void ain(String[] args)
        {
            var sl = new SortedList<int, string>();
            sl.Add(1, "alpha");
            sl.Add(3, "gamma");
            sl.Add(2, "beta");
            
            foreach (var item in sl)
            {
                Console.WriteLine(item);

            }
        }
    }
}
