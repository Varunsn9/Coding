using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    //class execution using command line
    public class CommandLineArguments
    {

        //compile using code : csc CommandLineArguments.cs
        //execute : CommandLineArguments.exe 
        //add arguments at execution using : CommandLineArguments.exe Hi How Are you?
        public static void aain(string[] args)
        {
            Console.WriteLine("Length of the Arguments Length " + args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            Console.WriteLine("this is an Main Function in CommandLineArguments class");
        }
    }
}
