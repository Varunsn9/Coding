using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.PolyMorphism
{
    public class TestSealed
    {
        public virtual void Display()
        {
            Console.WriteLine("hi from testsealed");
        }
    }
    public class Sealed : TestSealed
    {

        public sealed override void Display()
        {
            Console.WriteLine("hi from sealed class");
        }
    }
    public sealed class TSealed : TestSealed
    {

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
            testSealed = new TSealed();
            testSealed.Display();
        }
    }
}