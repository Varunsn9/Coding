using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NonGenericCollection
{
    internal class ArrayListFromCollection
    {
        public static void main()
        {
            ArrayList list = new ArrayList();
            //list.Add(7);
            list.Add("sunday");
            //list.Add(1);
           list.Add("monday");
           // list.Add(2);
            list.Add("tuesday");
            Console.WriteLine(list[1]);
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            list.Sort();
            //sorts only when the data is single type
            Console.WriteLine( "sorting the ArrayList using Sort method" );

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.RemoveAt(0);
            
            Console.WriteLine("======================");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
