using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Operators
{
    public class RelationalOperators
    {
        public static void aain(string[] args)
        {
            int x = 10, y = 5;

            // Equal to operator (==): Returns true if the operands are equal, otherwise false.
            bool equal = (x == y);
            Console.WriteLine("{0} == {1}: {2}", x, y, equal); // Output: "10 == 5: False"

            // Not equal to operator (!=): Returns true if the operands are not equal, otherwise false.
            bool notEqual = (x != y);
            Console.WriteLine("{0} != {1}: {2}", x, y, notEqual); // Output: "10 != 5: True"

            // Greater than operator (>): Returns true if the left operand is greater than the right operand, otherwise false.
            bool greaterThan = (x > y);
            Console.WriteLine("{0} > {1}: {2}", x, y, greaterThan); // Output: "10 > 5: True"

            // Less than operator (<): Returns true if the left operand is less than the right operand, otherwise false.
            bool lessThan = (x < y);
            Console.WriteLine("{0} < {1}: {2}", x, y, lessThan); // Output: "10 < 5: False"

            // Greater than or equal to operator (>=): Returns true if the left operand is greater than or equal to the right operand, otherwise false.
            bool greaterThanOrEqual = (x >= y);
            Console.WriteLine("{0} >= {1}: {2}", x, y, greaterThanOrEqual); // Output: "10 >= 5: True"

            // Less than or equal to operator (<=): Returns true if the left operand is less than or equal to the right operand, otherwise false.
            bool lessThanOrEqual = (x <= y);
            Console.WriteLine("{0} <= {1}: {2}", x, y, lessThanOrEqual); // Output: "10 <= 5: False"

            
        }

    }
}
