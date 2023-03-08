using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Generic_CSharp

{//generic class
    public class GenericClass<T>
    {
        public GenericClass(T t) 
        { 
        Console.WriteLine(t);
        }
    }
    //generic Method
    public class GenericMethod
    {
        public void show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }

    public class Gen
    {
        public static void aain(string[] args) 
        {
            GenericClass<string> s = new GenericClass<string>("hello this is Main Method");
            GenericClass<int> ss = new GenericClass<int>(101);
            GenericClass<char> bs = new GenericClass<char>('A');

            GenericMethod gm = new GenericMethod();
            gm.show("hello");
            gm.show(101);
            gm.show('A');
        }
       

    }
}
