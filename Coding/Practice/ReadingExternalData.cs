using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Practice
{
    public class ReadingExternalData
    {
        public static void main(String[] args)
        {
            Console.WriteLine( "enter a text to store in the string variable" );
            string variable = Console.ReadLine();
            Console.WriteLine("enter a int value to store in the int variable");
            int va=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( " the string value and int value entered into a vaiable is "+ variable+"  " +va);
        }
    }
}
