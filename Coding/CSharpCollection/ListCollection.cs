using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.CSharpCollection
{
    public class ListCollection
    {
        public static void main(String[] args)
        {
            //adding to an array
            var vehicals= new List<string>();
            //we are storing bmw in vehicals List
            vehicals.Add("bmw");
            vehicals.Add("audi");
            //Console.WriteLine(vehicals[0]);
            //initialazation at the time of creation
            IList<string> names=new List<string> { "varun","yusuf"};
            //Console.WriteLine(names[1]);
            names.Add("lakshmi");
             
            foreach(string a in names)
            {
                Console.WriteLine(a);
            }
        
        
        
        }
    }
}
