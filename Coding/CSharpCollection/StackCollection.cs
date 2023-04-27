using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.CSharpCollection
{
    /// <summary>
    /// This is a Stack collection class
    /// </summary>
    public class StackCollection
    {
        public static void main(string[] args)
        {
            var stack = new Stack<string>();
            stack.Push ("A");
            stack.Push ("B");
            stack.Push ("C");
            stack.Push ("D");
            stack.Push ("E");
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
        }
    }
}
