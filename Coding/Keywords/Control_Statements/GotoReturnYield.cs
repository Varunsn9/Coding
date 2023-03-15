using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Coding.Keywords.Control_Statements
{

        class MyClass
        {
            public void PrintNumbers()
            {
                int i = 0;
            Start:
                if (i >= 10)
                {
                    return;
                }
                Console.WriteLine(i);
                i++;
                goto Start;
            }

            public IEnumerable<int> GetNumbers()
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        continue;
                    }
                    yield return i;
                }
            }
        }

    public class GotoReturnYield
    {
        static void jin(string[] args)
        {
            MyClass myClass = new MyClass();

            // Using goto and return
            myClass.PrintNumbers(); // Output: 0 1 2 3 4 5 6 7 8 9

            // Using yield
            foreach (int i in myClass.GetNumbers())
            {
                Console.WriteLine(i);
            } // Output: 1 3 5 7 9
        }
    }
        
        /*
        In this example, we have a MyClass class that defines two methods: PrintNumbers and GetNumbers.

        The PrintNumbers method uses a goto statement to jump to a label called Start.
        The method has a loop that prints numbers from 0 to 9 and increments a counter variable i on each iteration.
        If i becomes greater than or equal to 10, the method returns and exits.The goto statement jumps back to the Start label to continue the loop.

        The GetNumbers method uses a yield statement to return a sequence of odd numbers from 1 to 9.
        The method has a loop that checks if the current number is even.
        If it is, the continue statement skips the rest of the loop body and goes to the next iteration. 
        If the number is odd, the yield return statement returns the number and suspends the method's execution until the next iteration.

        In the Main method, we create an instance of MyClass called myClass and call its PrintNumbers method to print numbers from 0 to 9 using goto and return statements.
        Then we use a foreach loop to iterate over the sequence of odd numbers returned by the GetNumbers method and print them to the console.

        By running the Main method, we can validate that the code works as intended and uses goto, return, and yield statements correctly.*/
    
}
