using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.CSharpCollection
{
    public class ListCollection
    {
        public static void aain(String[] args)
        {
            //adding to an array
            var vehicals= new List<string>();
            vehicals.Add("bmw");
            vehicals.Add("audi");
            Console.WriteLine(vehicals[0]);
            //initialazation at the time of creation
            var names=new List<string> { "varun","yusuf"};
            Console.WriteLine(names[1]);
        
        
        
        }
    }
}
