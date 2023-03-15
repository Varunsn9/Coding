using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Keywords
{
    public class VariablesAndValues
    {

            // Declare variables of various types
            bool myBoolean = true;
            byte myByte = 100;
            sbyte mySByte = -100;
            short myShort = 30000;
            ushort myUShort = 60000;
            int myInt = 2000000000;
            uint myUInt = 4000000000;
            long myLong = 9000000000000000000;
            ulong myULong = 18000000000000000000;
            float myFloat = 3.14f;
            double myDouble = 3.14159265358979;
            decimal myDecimal = 123456789.0123456789M;
            char myChar = 'A';
            string myString = "Hello, World!";
            object myObject = new object();

            // Declare a nullable type variable
            int? myNullableInt = null;

            // Declare a constant variable
            const int MyConstant = 100;

            // Declare a readonly variable
            readonly int MyReadOnlyInt;

            // Declare a static variable
            static int MyStaticInt = 200;

            // Declare an instance constructor
            public VariablesAndValues(int value)
            {
                MyReadOnlyInt = value;
            Console.WriteLine(MyReadOnlyInt.ToString());
            }

        // Declare a method that uses the variables
        public void MyMethod()
        {
            Console.WriteLine("myBoolean: " + myBoolean);
            Console.WriteLine("myByte: " + myByte);
            Console.WriteLine("mySByte: " + mySByte);
            Console.WriteLine("myShort: " + myShort);
            Console.WriteLine("myUShort: " + myUShort);
            Console.WriteLine("myInt: " + myInt);
            Console.WriteLine("myUInt: " + myUInt);
            Console.WriteLine("myLong: " + myLong);
            Console.WriteLine("myULong: " + myULong);
            Console.WriteLine("myFloat: " + myFloat);
            Console.WriteLine("myDouble: " + myDouble);
            Console.WriteLine("myDecimal: " + myDecimal);
            Console.WriteLine("myChar: "+ myChar);
            Console.WriteLine("myString: "+ myString);
            Console.WriteLine("myObject: " + myObject);
            Console.WriteLine("myNullableInt: " + myNullableInt);
            Console.WriteLine("MyConstant: " + MyConstant);
            Console.WriteLine("MyStaticInt: " + MyStaticInt);
            Console.WriteLine("myReadOnlyInt: " + new VariablesAndValues(123));
        }
        

       public static void ain(String[] args)
        {
            VariablesAndValues variablesAndValues=new VariablesAndValues(123);
            variablesAndValues.MyMethod();
        }
    }
}
