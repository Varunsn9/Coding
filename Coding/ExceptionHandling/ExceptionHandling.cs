using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.ExceptionHandling
{
    public class ExceptionHandling : Exception
    {
        public ExceptionHandling(String message) 
        :base(message)
        { 
            
        }
    }
    public class TestUserDefinedException
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new ExceptionHandling("Sorry, Age must be greater than 18");
            }
        }
        public static void aain(string[] args)
        {
            try
            {
                validate(12);
            }
            catch (ExceptionHandling e) { Console.WriteLine(e); }
            Console.WriteLine("Rest of the code");
        }
    }
}
