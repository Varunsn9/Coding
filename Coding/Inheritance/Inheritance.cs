using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Inheritance
{
    public class _BaseClass
    {
        public void Show() {

            Console.WriteLine("This is a Show Method/Function in _BaseClass");
        }
    }
    public class _DerivedClass : _BaseClass
    {
        /// <summary>
        /// this is a Display method 
        /// </summary>
        /// <param name="a"> this will take int as a value</param>
        public void Display(int a)
        {
            Console.WriteLine("This is a Display Method/Function in _DerivedClass");
        }
    }


    public class Inheritance
    {
        public static void main(String[] args)
        {
            _DerivedClass derivedClass=new _DerivedClass();
            derivedClass.Show();
            derivedClass.Display(1);
        }
    }


    

}
