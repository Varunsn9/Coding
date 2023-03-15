using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Keywords.Control_Statements
{
    public class Loops
    {
        public static void aain()
        {
            Loops looping = new Loops();
            looping.WhileLoopExample();
            looping.DoWhileLoopExample();
            looping.ForLoopExample();
            looping.ForeachLoopExample();
        }

        // While loop example
        public void WhileLoopExample()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("While loop iteration " + i);
                i++;
            }
            Console.WriteLine();
        }

        // Do-while loop example
        public void DoWhileLoopExample()
        {
            int i = 0;
            do
            {
                Console.WriteLine("Do-while loop iteration " + i);
                i++;
            } while (i < 10);
            Console.WriteLine();
        }

        // For loop example
        public void ForLoopExample()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("For loop iteration " + i);
            }
            Console.WriteLine();
        }

        // Foreach loop example
        public void ForeachLoopExample()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int i in array)
            {
                if (i == 5)
                {
                    Console.WriteLine("Breaking out of foreach loop");
                    break;
                }
                if (i == 3)
                {
                    Console.WriteLine("Continuing to next iteration of foreach loop");
                    continue;
                }
                Console.WriteLine("Foreach loop iteration " + i);
            }
            Console.WriteLine();
        }
    }
    /*
    In this class, the Main method is used to call each of the loop examples, and the output is displayed to the console.

    The WhileLoopExample method uses a while loop to iterate through the numbers 0 to 9 and print out each iteration to the console.

    The DoWhileLoopExample method uses a do-while loop to do the same thing as the while loop example.


    The ForLoopExample method uses a for loop to iterate through the numbers 0 to 9 and print out each iteration to the console.

    The ForeachLoopExample method uses a foreach loop to iterate through an array of integers and print out each iteration to the console.It also includes examples of using the break and continue keywords to break out of the loop and skip to the next iteration, respectively.

    By calling the Main method of the Looping class, the output of each loop example is displayed in the console.This allows the validation of the functionality of the loops and the break and continue keywords.
    */





}
