using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.CSharpCollection
{
    public class HashSetCollection
    {

        public static void main(string[] args)
        {
        
            var hs = new HashSet<String>();
            hs.Add("a");
            hs.Add("b");
            hs.Add("c");
            hs.Add("d");
            hs.Add("e");
            hs.Add("a");
            hs.Add("b");
            hs.Add("c");
            hs.Add("d");
            foreach (var item in hs) 
            {
            Console.WriteLine(item);
            }
            
        }
    }
}
