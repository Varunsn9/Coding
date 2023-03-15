using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Operators
{
    public class LogicalOperators
    {
        public static void aain(string[] args)
        {
            bool a = true, b = false, c = true;

            // AND operator (&&): Returns true if both operands are true, otherwise false.
            bool andResult = (a && c);
            Console.WriteLine("{0} && {1}: {2}", a, c, andResult); // Output: "True && True: True"

            // OR operator (||): Returns true if at least one of the operands is true, otherwise false.
            bool orResult = (a || b);
            Console.WriteLine("{0} || {1}: {2}", a, b, orResult); // Output: "True || False: True"

            // NOT operator (!): Returns the opposite of the operand's value, true becomes false and false becomes true.
            bool notResult = !a;
            Console.WriteLine("!{0}: {1}", a, notResult); // Output: "!True: False"

            // AND operator with short-circuit evaluation (&&): If the left operand is false, the right operand is not evaluated.
            bool andShortCircuit = (b && (5 > 0)); // The right operand is not evaluated because the left operand is false.
            Console.WriteLine("{0} && (5 > 0): {1}", b, andShortCircuit); // Output: "False && (5 > 0): False"

            // OR operator with short-circuit evaluation (||): If the left operand is true, the right operand is not evaluated.
            bool orShortCircuit = (a || (5 > 0)); // The right operand is not evaluated because the left operand is true.
            Console.WriteLine("{0} || (5 > 0): {1}", a, orShortCircuit); // Output: "True || (5 > 0): True"

        }

    }
}
