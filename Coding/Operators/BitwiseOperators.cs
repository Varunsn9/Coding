using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Operators
{
    public class BitwiseOperators
    {
        public static void aain(string[] args)
        {
            /*
             * bit code of each number
                0: 0000         
                1: 0001         
                2: 0010         
                3: 0011
                4: 0100
                5: 0101
                6: 0110
                7: 0111
                8: 1000
                9: 1001
             */

            int x = 15; // binary value 0000 1111
            int y = 9; // binary value 0000 1001

            // AND operator (&): Returns a 1 in each bit position where both operands have a 1, otherwise 0.
            int andResult = x & y; // binary value 0000 1001
            Console.WriteLine("{0} & {1} = {2}", x, y, andResult); // Output: "15 & 9 = 9"

            // OR operator (|): Returns a 1 in each bit position where either operand has a 1, otherwise 0.
            int orResult = x | y; // binary value 0000 1111
            Console.WriteLine("{0} | {1} = {2}", x, y, orResult); // Output: "15 | 9 = 15"

            // XOR operator (^): Returns a 1 in each bit position where only one of the operands has a 1, otherwise 0.
            int xorResult = x ^ y; // binary value 0000 0110
            Console.WriteLine("{0} ^ {1} = {2}", x, y, xorResult); // Output: "15 ^ 9 = 6"

            // Complement operator (~): Inverts all the bits of the operand.
            int complementResult = ~x; // binary value 1111 0000
            Console.WriteLine("~{0} = {1}", x, complementResult); // Output: "~15 = -16"

            // Left shift operator (<<): Shifts the bits of the first operand to the left by the number of positions specified by the second operand.
            int leftShiftResult = x << 2; // binary value 0011 1100
            Console.WriteLine("{0} << 2 = {1}", x, leftShiftResult); // Output: "15 << 2 = 60"

            // Right shift operator (>>): Shifts the bits of the first operand to the right by the number of positions specified by the second operand.
            int rightShiftResult = x >> 2; // binary value 0000 0011
            Console.WriteLine("{0} >> 2 = {1}", x, rightShiftResult); // Output: "15 >> 2 = 3"

            
        }

    }
}
