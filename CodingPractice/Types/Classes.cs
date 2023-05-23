using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Types
{
    public class Classes<TClas>
    {
        public TClas Clas { get; set; }

        public Classes() { }
        public void Store(TClas a)
        {
                Clas = a;
        }
     
    }
    public class Testing 
    {
        public static void main()
        {
            Classes<string> s=new Classes<string>() { };
            Console.WriteLine(s.Clas+" value before adding method");
            s.Store("Storing A inside Clas");
            Console.WriteLine(s.Clas+ " = value after adding method");
        }
    }

    public class ABC
    {
        public int A { get; }
        public int B { get; }

        public ABC(int a,int b) {
            A = a;
            B = b;
        }
    }
    public class CBA
    {
        public static void main()
        {
            var a = new ABC(0, 0);
            var b = new ABC(10, 20);


            ABC aa = new(1, 2);
            ABC ab = new AAA(10, 20, 30);
        }
    }
    public class AAA : ABC
    {
        public int C { get; set; }
        public AAA(int a,int b,int c) : base(a, b)
        {
            C = c;
        }
    }

}
