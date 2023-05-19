using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Constructors
{
    internal class ParameterlessConstructor
    {
         public string day = "monday";
        //there is no explicit constructor
        //c# compilier will implicitly creates a paremeterless Constructor
    }
    public class Construtors
    {
        public static void main()
        {
            ParameterlessConstructor p=new ParameterlessConstructor();
            Console.WriteLine("Day:{0}",p.day);
        }
    }
}
