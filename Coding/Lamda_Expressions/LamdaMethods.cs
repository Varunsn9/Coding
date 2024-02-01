using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Lamda_Expressions
{
    public class LamdaMethods
    {
        public static void LamdaOrderBy()
        {
            int[] a = { 10, 9, 4, 3, 8, 6, 2, 1, 7, 5 };
            var n=a.OrderBy(x => x);
            var m=a.Where(x => x > 5);
            foreach( var x in m)
            Console.WriteLine(x);
        }
        
    }
}
