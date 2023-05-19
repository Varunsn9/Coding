using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NonGenericCollection
{
    internal class QueueFromCollection
    {
        public static void aain(string[] args)
        {
            Queue<int> ints = new Queue<int>();
            ints.Enqueue(1);
            ints.Enqueue(2);
            ints.Enqueue(3);
            ints.Enqueue(4);

            Console.WriteLine(ints);

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("========================");
            Console.WriteLine(ints.Dequeue());
            Console.WriteLine("========================");
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("========================");
            Console.WriteLine(ints.Peek());
        }
    }
}
