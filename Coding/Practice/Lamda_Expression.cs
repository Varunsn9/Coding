using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Practice
{
    public class Lamda_Expression
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
        public static void LamdaExp() 
        {
            List<int> li = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var val = li.Where(d => d < 6);
            foreach (int i in val)
            {
                Console.WriteLine(i);
            }
        }
        public static void LamdaPrimeNumber() 
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var prime = a.Where(b => b % 2 == 0 || b==1);
            foreach(int i in prime)
            {
                Console.Write($"{i},");
            }
            Console.WriteLine(" This numbers are prime numbers");
        }
        public static void LamdaUsingSelect()
        {
            int[] a = { 1, 2, 6, 7, 8, 9, 10,  3, 4, 5 };
            var selec = a.OrderBy(b => b);
            foreach(int i in selec)
            { Console.WriteLine(i); }

        }
    }
}
