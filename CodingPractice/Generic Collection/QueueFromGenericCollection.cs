using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Generic_Collection
{
    internal class QueueFromGenericCollection
    {
       public static void main()
        {
            Queue<int> ints = new Queue<int>();
            ints.Enqueue(1);
            ints.Enqueue(3);
            ints.Enqueue(2);
            
            foreach (int i in ints) {
                Console.WriteLine(i);
            }
            ints.Dequeue();
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            //first in first out
        }
    }
}
