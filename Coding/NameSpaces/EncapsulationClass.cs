using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.NameSpaces
{
    public class EncapsulationClass
    {
        public int id{ get; set; }
        
        
    }
    public class two
    {
        public static EncapsulationClass ec = new EncapsulationClass();
        public static void main(string[] args)
        {
            ec.id = 1;
            Console.WriteLine(ec.id);
        }
    }
}
