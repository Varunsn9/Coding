using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Coding
{
    public class GoToStatement
    {

        string ran = "rajeev";
        public static void main(String[] args)
        {
            repeat:
            Console.WriteLine("Enter your age");
            GoToStatement goToStatement = new GoToStatement();
            
            Console.WriteLine(goToStatement.ran); 

           var age= Convert.ToInt32(Console.ReadLine());
            if (age <= 18)
            {
                Console.WriteLine("u r too young to vote");
            }
            else
            {
                Console.WriteLine("u can vote");
            }
            goto repeat;
        }
    }
}
