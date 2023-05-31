using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Types
{
    internal class TypeParameters<TFirst,TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }
        public TypeParameters(TFirst first, TSecond second) =>
            (First, Second) = (first, second); 
    }

    public class TypeParametersSubClass
    {

        public static void main()
        {
           var a= new TypeParameters<int, string>(1, "String");
            a.First = 1;        //TFirst int
            a.Second = "hello"; //TSecond string

        }
    }
    

    
}
