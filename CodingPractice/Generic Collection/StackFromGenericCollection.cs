using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Generic_Collection
{
    internal class StackFromGenericCollection
    {
        public static void main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            //Represents a variable size last -in-first -out(LIFO)collections of instance of the same specified type.
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            //4321 stored in 
            Console.WriteLine(stack.Peek());
            Console.WriteLine("===============================");
            foreach (int i in stack) { 
            
                Console.WriteLine(i);
        } 
            stack.Pop();
            Console.WriteLine("==============================");
            foreach (int i in stack)
            {

                Console.WriteLine(i);
            }
            
        }
    }
}
