using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.ObjectAndClass
{
    //static class
    public static class StaticClass
    {
        //static 
        public static int rateOfInterest=8;
        
        static StaticClass() {
            Console.WriteLine("Static constructor");
        }
    }

    public class StaticIntrest
    {
        public static void aain(string[] args)
        {
            
            Console.WriteLine(StaticClass.rateOfInterest);
        }

    }
}
