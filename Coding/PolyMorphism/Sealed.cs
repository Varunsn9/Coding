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
            Console.WriteLine("hi");
        }
    }
    public class Sealed : TestSealed
    {

        public sealed override void Display()
        {
            Console.WriteLine("hi");
        }
    }
    public class TSealed : TestSealed
    {

        public sealed override void Display()
        {
            Console.WriteLine("hi");
        }
    }

    public class Output
    {
        public static void ain(String[] args)
        {
            TestSealed testSealed = new Sealed();
            testSealed.Display();   

        }
    }
}