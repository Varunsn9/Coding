using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    public class MainClass
    {
        public static void Main()
        {
            string sentance = Console.ReadLine();
            string[] words = sentance.Split(" ");
            for(int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                for(int j = word.Length-1; j >=0 ; j--)
                {
                    Console.Write(word[j]);
                }
                Console.Write(" ");
                Console.Write(" ");
            }
                
            
        }
    }
}
