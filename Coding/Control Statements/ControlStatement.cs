using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Control_Statements
{
    public class IfElse
    {
        public static void ain()
        {
            int number = 1;
            if (number < 5)
            {
                Console.WriteLine(number +" is less than 5");

            }
            else
            {
                Console.WriteLine(number+" is greater than 5 ");
            }
        }
    }
    public class Switch
    {
        public static void ain()
        {
            Console.WriteLine("Enter A Number");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 10: Console.WriteLine("It is 10"); break;
                case 20: Console.WriteLine("It is 20"); break;
                case 30: Console.WriteLine("It is 30"); break;
                default: Console.WriteLine("no case are avaliable for this number"); break;
            }
        }
    }
    public class ForLoop
    {
        //ForLoop
        public static void ain() 
        {
        for(int i = 0; i<=10; i++)
            {
                Console.WriteLine(i);
            }
        }
        //NestedForLoop
        public static void nain()
        {
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine("External loop = "+i);
                for(int j = 0; j <= 5; j++)
                {
                    Console.WriteLine("Internal Loop = " +j);
                }
            }
        }
        //Inifinity Loop
        public static void oain()
        {
            for(; ;)
            {
                Console.WriteLine("Infinity Loop");
            }
        }
    }
    //While Loops
    public class WhileLoop
    {
        //While Loop
        public static void aain()
        {
            int number = 1;
            while (number <= 10)
            {
                Console.WriteLine(number +" is less than 10");
                number++;
            }
        }
        //Nested While loop
        public static void bain()
        {
            int number = 1;
            while (number <= 10)
            {
                Console.WriteLine("ExternalLoop "+ number);
                int num = 1;
                while (num <= 5)
                {
                    Console.WriteLine("Inner loop "+number);
                    num++;
                }
                number++;
            }
        }
        //Infinity While Loop 
        public static void cain()
        {
            while (true)
            {
                Console.WriteLine("Infinity loop");
            }
        }
    }
    //Do While Loop
    public class DoWhileLoop
    {
        //Do While Loop
        public static void aain() 
        {
            int number = 1;
            do
            {
                Console.WriteLine(number);
                number++;
            } while (number <= 10);
            
        }
        //nested do while loop
        public static void bain()
        {
            int i = 0;
            do
            {int j = 0;
                do
                {
                    Console.WriteLine(i+" "+j);
                    j++;
                }while(j <= 3);
                i++;
            } while (i <= 2);
        }
        //Infiniy Do While loop
        public static void cain()
        {
            do
            {
                Console.WriteLine("Infinity Loop");
            } while (true);
        }
    }


    //Break Control StateMent
    public class Break
    {
        public static void ain()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
    // Continue Control StateMent
    public class Continue
    {
        public static void ain()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
    //GoTo Control StateMent
    public class Goto
    {
        public static void main()
        {
        youAre:
            Console.WriteLine("your are not eligible");
            Console.WriteLine("Enter your age");
           
                if (Convert.ToInt32(Console.ReadLine())<18)
                {
                    goto youAre;
                }
                else
                {
                    Console.WriteLine("your are eligible");
                }
        }
    }
    //Comments Control StateMent
    public class Comments
    {
        public static void ain()
        {
                    //single line comment
            //      string words="Test Engineers";
          
                   //multiline comment
            
            /*      string word = "Test Engineers";
                    int number = 0;
            */
            }
    }
}
