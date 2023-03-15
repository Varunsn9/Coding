using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Keywords
{
    public class TypeMembers
    { 

    }
       
    // Declare an enum type
    public enum MyEnum { Value1, Value2, Value3 }

        // Declare a delegate type
        public delegate void MyDelegate();

        // Declare a class
        public class MyClass
        {
            // Declare a constant field
            public const int MyConstant = 100;

            // Declare a read-only field
            public readonly int MyReadOnlyField;

            // Declare a static field
            public static int MyStaticField;

            // Declare an instance constructor
    
            public MyClass(int value)
            {
                MyReadOnlyField = value;
            }

            // Declare a static constructor
            static MyClass()
            {
                MyStaticField = 200;
            }

            // Declare a method with a parameter of the delegate type
            public void MyMethod(MyDelegate myDelegate)
            {
                Console.WriteLine("Calling MyDelegate...");
                myDelegate();
            }

            // Declare a property with a private setter
            public int MyProperty { get; private set; }

            // Declare an indexer
            public string this[int index]
            {
                get { return "Item " + index; }
                set { Console.WriteLine("Setting value for Item " + index + ": " + value); }
            }

            // Declare an event
            public event EventHandler MyEvent;

            // Declare a nested class
            public class MyNestedClass
            {
                // Declare a nested enum
                public enum MyNestedEnum { NestedValue1, NestedValue2, NestedValue3 }

                // Declare a nested method
                public void MyNestedMethod()
                {
                    Console.WriteLine("This is a nested method.");
                }
  
            }
        }
}
/*
 In this example, we have a class MyClass with various types and type members:

enum: The MyEnum enum type is declared with three values.
delegate: The MyDelegate delegate type is declared with no parameters and no return value.
class: The MyClass class is declared with various type members.
const: The MyConstant field is declared as a constant with a value of 100.
readonly: The MyReadOnlyField field is declared as a read-only field and initialized in the constructor.
static: The MyStaticField field is declared as a static field and initialized in the static constructor.
constructor: The MyClass class has an instance constructor and a static constructor.
method: The MyMethod() method is declared with a parameter of the MyDelegate delegate type.
property: The MyProperty property is declared with a private setter.
indexer: The class has an indexer that allows accessing elements by an index.
event: The MyEvent event is declared as an instance of the EventHandler delegate type.
nested class: The MyNestedClass nested class is declared within the MyClass class.
nested enum: The MyNestedEnum enum type is declared within the MyNestedClass class.
nested method: The MyNestedMethod() method is declared within the MyNestedClass class.

 */
