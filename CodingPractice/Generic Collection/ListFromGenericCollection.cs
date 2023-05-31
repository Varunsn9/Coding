using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Generic_Collection
{
    public class ListFromGenericCollection
    {
        public static void main(string[] args)
        {
            List<string> list = new List<string>(4);
            list.Add("1");
           list.Add("2");
            list.Add("3");
           list.Add("4");
           list.Add("5");
            Console.WriteLine(list[4]);
            Console.WriteLine(list[0]);
            Console.WriteLine(list.Capacity);
            list[0] = "5";
            Console.WriteLine(list[0]);
           // list.Clear();
            Console.WriteLine(list.Capacity);

            Console.WriteLine(  "==================================");
            foreach(string a in list)
            {
                Console.Write(a);
            }
        }
    }
}
