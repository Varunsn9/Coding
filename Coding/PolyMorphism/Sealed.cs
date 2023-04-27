using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.PolyMorphism
{
    public class TestSealed
    {
        public TestSealed() {
            Console.WriteLine("TestSealed Classs");
            this.Display();
        }
        public virtual void Display()
        {
            Console.WriteLine("hi from testsealed");
        }
    }
    public class Sealed : TestSealed
    {
        public Sealed()
        {
            Console.WriteLine("This is a super class");
        }

        public sealed override void Display()
        {
            Console.WriteLine("hi from sealed class");
        }
    }
    public sealed class TSealed : TestSealed
    {
        public TSealed() : base() 
        {
            Console.WriteLine( " this is a TSealed Class " );
        }

        public sealed override void Display()
        {
            Console.WriteLine("hi");
        }
    }

    public class Output 
    {
        public const int number = 1;

        public static void main(String[] args)
        {
            TestSealed testSealed = new Sealed();
            testSealed.Display();
            Console.WriteLine(  "------------------" );
            testSealed = new TSealed();
            testSealed.Display();
            Console.WriteLine(  "------------------------------" );
            TSealed s=new TSealed();
            s.Display();

            
        }
    }
}