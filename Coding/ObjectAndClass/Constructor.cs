using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.ObjectAndClass
{
    public class Constructor
    {
        //default constructor or constructor withour arguments
        public Constructor() 
        {
            Console.WriteLine("constructor without arguments");
        }
        //parameterized constructor
        public Constructor(string value)
        {
            Console.WriteLine("constructor with string arguments " +value);
        }
        public static void aain(string[] args)
        {
            Constructor c = new Constructor();
            Constructor c1=new Constructor("Hello");
        
        }
    }
}
