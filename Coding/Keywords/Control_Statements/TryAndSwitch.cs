using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Keywords.Control_Statements
{
    //// This is a sample class that uses switch-case statements and a finally block
    public class TryAndSwitch
    {
        // Method to print a message based on the day of the week
        public void PrintDayOfWeek(int day)
        {
            try
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Today is Monday.");
                        break;
                    case 2:
                        Console.WriteLine("Today is Tuesday.");
                        break;
                    case 3:
                        Console.WriteLine("Today is Wednesday.");
                        break;
                    case 4:
                        Console.WriteLine("Today is Thursday.");
                        break;
                    case 5:
                        Console.WriteLine("Today is Friday.");
                        break;
                    case 6:
                        Console.WriteLine("Today is Saturday.");
                        break;
                    case 7:
                        Console.WriteLine("Today is Sunday.");
                        break;
                    default:
                        Console.WriteLine("Invalid day of the week.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of method.");
            }
        }
        static void aain(string[] args)
        {
            TryAndSwitch myClass = new TryAndSwitch();

            // Valid day of the week
            myClass.PrintDayOfWeek(3); // Output: Today is Wednesday. End of method.

            // Invalid day of the week
            myClass.PrintDayOfWeek(8); // Output: Invalid day of the week. End of method.

            // Exception handling
            try
            {
                myClass.PrintDayOfWeek(-1); // Output: Invalid day of the week. End of method.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
        }
    }
}
