using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Coding.PolyMorphism
{
    public class MethodOverloading
    {
        public void Display()
        {
            Console.WriteLine("without parameter");
        }
        public void Display(string name)
        {
            Console.WriteLine(name);
        }
        public static int Add(int a,int b)
        {
            int num = a + b;
            return num;
        }

        public static int Add(int a, int b,int c)
        {
            int num = a + b+c;
            return num;
        }
        public static void aain(string[] args)
        {
            MethodOverloading methodOverloading=new MethodOverloading();
            methodOverloading.Display();
            methodOverloading.Display("With string Parameter");
            Console.WriteLine(MethodOverloading.Add(1,2));
            Console.WriteLine(MethodOverloading.Add(1,2,3));
        }
    }
}
