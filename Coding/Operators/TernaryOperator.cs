using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Operators
{
 public class TernaryOperator
    {
       public static void main()
        {
            int x = 5, y = 10;
            bool b = true;

            // conditional operator (?:)
            int z = b ? x : y;
            Console.WriteLine($"z = {z}");  // prints "z = 5"

            // null-coalescing operator (??)
            string s = null;
            string t = s ?? "default";
            Console.WriteLine($"t = {t}");  // prints "t = default"

            // null-conditional operator (?.)
            string[] arr = null;
            int? len = arr?.Length;
            Console.WriteLine($"len = {len}");  // prints "len = "

            arr = new string[] { "a", "b", "c" };
            len = arr?.Length;
            Console.WriteLine($"len = {len}");  // prints "len = 3"
        }
    }

}
