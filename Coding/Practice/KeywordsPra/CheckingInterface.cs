using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Practice.KeywordsPra
{
     interface CheckingInterface
    {
        public void Check();    
    }

    class Sub : CheckingInterface
    {
        public void Check()
        {
            string sentance = "implementing the check method from interface";
            Console.WriteLine( $"{0}",sentance );
        }
     //   public static void Main(String)
    }
}
