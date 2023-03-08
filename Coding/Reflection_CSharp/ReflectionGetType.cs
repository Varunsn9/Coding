using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Reflection_CSharp
{
    public class ReflectionGetType
    {
        public static void ain(String[] args)
        {
            int a = 0;
            Type t=a.GetType();
            Console.WriteLine(t);
            Console.WriteLine(t.Namespace); 
        }
    }
}
