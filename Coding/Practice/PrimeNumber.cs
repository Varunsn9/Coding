using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Practice
{
    public class PrimeNumber
    {
        public static void main(String[] args)
        {
            Statement:
            Console.WriteLine("enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            
            if (prime(number) == true)
            {
                Console.WriteLine("is prime");
            }
            else
            {
                Console.WriteLine("not a prime");
            }
            goto Statement;
        }
        public static Boolean prime(int number)
        {
            for(int i = 2; i <= number / 2; i++)
            {
                if (number < 3)
                {
                    return true;
                    
                }
                else if (number % i == 0)
                {
                        return false;
                    
                }
                
            }
            return true;
        }
    }
}
