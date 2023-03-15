using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Keywords
{
    //Public class accessible from anywhere
    public class AccessModifiers
    {
        // Private field accessible only within the class
        private int myPrivateField;

        // Protected field accessible only within the class and its derived classes
        protected int myProtectedField;

        // Internal field accessible only within the assembly
        internal int myInternalField;

        // Protected internal field accessible within the assembly and its derived classes
        protected internal int myProtectedInternalField;

        // Public field accessible from anywhere
        public int myPublicField;

        // Private method accessible only within the class
        private void MyPrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }

        // Protected method accessible only within the class and its derived classes
        protected void MyProtectedMethod()
        {
            Console.WriteLine("This is a protected method.");
        }

        // Internal method accessible only within the assembly
        internal void MyInternalMethod()
        {
            Console.WriteLine("This is an internal method.");
        }

        // Protected internal method accessible within the assembly and its derived classes
        protected internal void MyProtectedInternalMethod()
        {
            Console.WriteLine("This is a protected internal method.");
        }

        // Public method accessible from anywhere
        public void MyPublicMethod()
        {
            Console.WriteLine("This is a public method.");
        }
    }
}
/*
In this example,
                we have a class MyClass with five fields and five methods,
                each using a different access modifier:

private: The myPrivateField field and MyPrivateMethod() method are marked as private,
            which means they are only accessible within the MyClass class.

protected: The myProtectedField field and MyProtectedMethod() method are marked as protected,
            which means they are accessible within the MyClass class and its derived classes.

internal: The myInternalField field and MyInternalMethod() method are marked as internal,
            which means they are accessible within the same assembly as the MyClass class.

protected internal: The myProtectedInternalField field and MyProtectedInternalMethod() method are marked as protected internal, 
                    which means they are accessible within the same assembly as the MyClass class and its derived classes.

public: The myPublicField field and MyPublicMethod() method are marked as public,
        which means they are accessible from anywhere.

*/
