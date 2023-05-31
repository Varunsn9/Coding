using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Constructors
{
    internal class PrimaryConstructor
    {
        //this is the constructor with parameters
        public PrimaryConstructor(string message) 
        {
            Console.WriteLine(message);
        }
    }
    public class Testing 
    {
        public static void main()
        {
            PrimaryConstructor pC=new PrimaryConstructor("String Message");
        }
    }
}
