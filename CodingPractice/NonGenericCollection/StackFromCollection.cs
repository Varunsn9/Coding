using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NonGenericCollection
{
    internal class StackFromCollection
    {
        public static void main()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(3);
            stack.Push(2);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Pop();
            Console.WriteLine("======================");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
