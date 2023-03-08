using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Coding.Delegates_CSharp
{
    public delegate int Calculator(int n);
    public delegate int CalculatorActions(int n, int a);

    public class DelegatesClass
    {
        static int a = 1;
        public static int add(int n)
        {
            var c = n + a;
            Console.WriteLine(c);
            return c;
        }
        public static int mul(int n)
        {
            var c = n * a;
            Console.WriteLine(c);
            return c;
        }
        public static int sub(int n)
        {

            var c = n - a;
            Console.WriteLine(c);
            return c;
        }
        public static int add(int n,int a)
        {
            var c = n + a;
            Console.WriteLine(c);
            return c;
        }
        public static int mul(int n, int a)
        {
            var c = n * a;
            Console.WriteLine(c);
            return c;
        }
        public static int sub(int n, int a)
        {

            var c = n - a;
            Console.WriteLine(c);
            return c;
        }
        public class DelegatesClassMain
        {
            public static void aain(String[] args)
            {
                Calculator c1 = new Calculator(add);
                Calculator c2 = new Calculator(mul);
                Calculator c3 = new Calculator(sub);
                c1(20);
                c2(20);
                c3(20);
                CalculatorActions ac = new CalculatorActions(add);
                CalculatorActions bc = new CalculatorActions(mul);
                CalculatorActions cc = new CalculatorActions(sub);
                ac(20, 10);
                bc(20, 10);
                cc(20, 10);

            }
        }
    }
   
}
