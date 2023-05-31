using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Constructors
{
    internal class StaticConstructor
    {
       public static string greetings;
        static StaticConstructor()
        {
            greetings = "hello";
            Console.WriteLine(greetings);
        }
        public StaticConstructor(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class Sub
    {
        public static void main()
        {
            StaticConstructor sC = new StaticConstructor("C# static Constructor EG");
            //output is hello
            //C# static Constructor EG
            StaticConstructor sC1 = new StaticConstructor("Instantiating 2nd Time");
        }
    }
}
