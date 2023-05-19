using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Constructors
{
    internal class CopyConstructor
    {
        public int wheels;
        public string vehicalType;
        public string VehicalType { get { return vehicalType; } set { vehicalType = value; } }
        public int Wheels { get { return wheels; } set { wheels = value; } }
        public CopyConstructor(int wheels, string vehicalType)
        //instance Constructor
        {
            VehicalType=vehicalType; Wheels = wheels;
        }
        public CopyConstructor(CopyConstructor copy) 
        //CopyConstructor
        {
             VehicalType = copy.VehicalType; Wheels = copy.Wheels;
        }
        public string Details()
        {
            return wheels + " " + vehicalType;
        }
    }
    public class Specification
    {
        public static void Main(string[] args)
        {
            CopyConstructor CC=new CopyConstructor(2,"bike");
            CopyConstructor CC2 = new CopyConstructor(CC);
            Console.WriteLine(CC2.Details());
            //we are changing the value of the person
            CC2.wheels=4;
            CC2.vehicalType = "Car";
            Console.WriteLine(CC.Details());
            Console.WriteLine(CC2.Details());
        }
    }
}
