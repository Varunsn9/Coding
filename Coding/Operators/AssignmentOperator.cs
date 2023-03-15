using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Operators
{
    public class AssignmentOperator
    {
        public static void aain()
        {

            int x = 5;
            int y;

            // assignment operator (=)
            y = x;
            Console.WriteLine($"y = {y}");  // prints "y = 5"

            // addition assignment operator (+=)
            y += x;  // equivalent to y = y + x;
            Console.WriteLine($"y = {y}");  // prints "y = 10"

            // subtraction assignment operator (-=)
            y -= x;  // equivalent to y = y - x;
            Console.WriteLine($"y = {y}");  // prints "y = 5"

            // multiplication assignment operator (*=)
            y *= x;  // equivalent to y = y * x;
            Console.WriteLine($"y = {y}");  // prints "y = 25"

            // division assignment operator (/=)
            y /= x;  // equivalent to y = y / x;
            Console.WriteLine($"y = {y}");  // prints "y = 5"

            // modulus assignment operator (%=)
            y %= x;  // equivalent to y = y % x;
            Console.WriteLine($"y = {y}");  // prints "y = 0"

        }
    }
}



