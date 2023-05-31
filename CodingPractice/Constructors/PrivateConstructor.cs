using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Constructors
{
    internal class PrivateConstructor
    {
        PrivateConstructor() { }
    }
    public class PConstructor
    {
        public static void main()
        {
            //PrivateConstructor Pc = new PrivateConstructor();
            //PrivateConsturctor() is not able to access due to its protection level
        }
    }
}
