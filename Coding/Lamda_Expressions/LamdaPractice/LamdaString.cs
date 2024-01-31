using Coding.Control_Statements;
using Coding.ObjectAndClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Coding.Lamda_Expressions.LamdaPractice
{
    public class LamdaString
    {
        static string a = "aaabbcccddeeabcab";
        char[] b = { 'a', 'b', 'c', 'f', 'e', 'h', 'a' };
        static int[] i = { 10, 9, 8, 7, 1, 2, 3, 4, 5, 6 };

        public static void Programming()
        {
            Func<int, bool> IsPrime = (num) => {
                bool a = true; for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0) { a = false; break; };
                }
                return a;
            };
            Action greet= () => Console.WriteLine("Hello Guys");
            greet();
            var even = i.Where(x => x % 2 == 0);
            foreach (var item in i)
            {
                if (IsPrime(item)) 
                { 
                Console.WriteLine(item);
                }
            }
          
        }
        public static void LString()
        {
            char[] a = { 'a', 'b', 'c', 'f', 'e', 'h','a' };
            var b = a.Where(c => c == 'a');
            var c=b.Count();
            Console.WriteLine(c);
        }
        public static void RemoveDuplicatesCharFromString() 
        {
            char[] b = a.ToCharArray(); 
            for(int i = 0; i < b.Length; i++)
            {
                int count = 1;
                for(int j = i+1; j < b.Length; j++)
                {
                    if (b[i] == b[j])
                    {
                        count++;
                        b[j] = ' ';
                    }
                }
                if (b[i]!=' ' && count>=1) { 
                Console.Write($"{b[i]}{ count},");
                }
            }
        }
        
    }
}
