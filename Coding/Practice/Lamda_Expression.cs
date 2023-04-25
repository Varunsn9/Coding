using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Practice
{
    internal class Lamda_Expression
    {
        public static void main(String[] args)
        {
            List<int> list = new List<int> { 2,3,4,5,6,7,8,9,10};
            List<int> list2 = list.Where(d => d % 2==0).ToList();
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }
        }
    }
}
