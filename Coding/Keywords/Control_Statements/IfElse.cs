using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Keywords.Control_Statements
{
        public class IfElse
        {
            // Integer variable to store a number
            int number;

            // Constructor for MyClass that takes an integer argument
            public IfElse(int number)
            {
                this.number = number;
            }

            // Method to check if the number is even or odd
            public void CheckEvenOrOdd()
            {
                // If the number is even
                if (number % 2 == 0)
                {
                    Console.WriteLine(number + " is even.");
                }
                // If the number is odd
                else
                {
                    Console.WriteLine(number + " is odd.");
                }
            }

            // Method to check if the number is positive, negative, or zero
            public void CheckPositiveNegativeZero()
            {
                // If the number is positive
                if (number > 0)
                {
                    Console.WriteLine(number + " is positive.");
                }
                // If the number is negative
                else if (number < 0)
                {
                    Console.WriteLine(number + " is negative.");
                }
                // If the number is zero
                else
                {
                    Console.WriteLine(number + " is zero.");
                }
            }
        public static void main(string[] args)
        {
            IfElse ifElse=new IfElse(3);
            ifElse.CheckPositiveNegativeZero();
            ifElse.CheckEvenOrOdd();
        }

        }
}
