using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Operators
{
    public class UnaryOperators
    {
     
       public static void main()
        {
            int x = 5;
            int y;

            // unary plus operator (+)
            y = +x;
            Console.WriteLine($"y = {y}");  // prints "y = 5"

            // unary minus operator (-)
            y = -x;
            Console.WriteLine($"y = {y}");  // prints "y = -5"

            // prefix increment operator (++)
            y = ++x;
            Console.WriteLine($"x = {x}, y = {y}");  // prints "x = 6, y = 6"

            // postfix increment operator (++)
            y = x++;
            Console.WriteLine($"x = {x}, y = {y}");  // prints "x = 7, y = 6"

            // prefix decrement operator (--)
            y = --x;
            Console.WriteLine($"x = {x}, y = {y}");  // prints "x = 6, y = 6"

            // postfix decrement operator (--)
            y = x--;
            Console.WriteLine($"x = {x}, y = {y}");  // prints "x = 5, y = 6"

         
       }
    }
}
