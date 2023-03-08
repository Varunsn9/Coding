using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.StringClass
{
    public class StringClass
    {
        public static void aain(String[] args)
        {
            String a = "Var u n";
            String b = "Yusuf";
            var c=a.Split(' ');
            int i = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine(c[i]);
                }
                catch(Exception e)
                {
                    break;
                }
                i++;
            }

            Console.WriteLine(c);
        }

        
    }
}
