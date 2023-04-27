using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.CSharpCollection
{
    public class LinkedListCollection
    {
        public static void aain(String[] args)
        {
            
            var ll = new LinkedList<string>();
            ll.AddFirst("one");
            ll.AddFirst("two");
            ll.AddFirst("three");
            ll.AddLast("four");
            ll.AddLast("five");
            ll.AddLast("six");
 
            foreach (var item in ll)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------");
            
            LinkedListNode<string> node=ll.Find("two");
            ll.AddAfter(node,"yusuf");
            ll.AddBefore(node,"varun");

            foreach(var item in ll)
            {
                Console.WriteLine(item);
            }
        }
    }
}
