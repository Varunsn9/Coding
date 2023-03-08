using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Functions
{
    //Functions
    public class Functions
    {
        public void Show()
        {
            Console.WriteLine("Show Function");
        }

        public void Show(string word)
        {
            Console.WriteLine("Show Function with Parameter " + word);
        }
        public string ShowWithReturnType()
        {
            string sent = "Show Function with returntype";
            return sent;
        }

        //Main Method
        public static void main(string[] args)
        {
            Functions functions = new Functions();
            //function without parameter
            functions.Show();
            //function with returntype
            string value = functions.ShowWithReturnType();
            Console.WriteLine(value);
            //function with parameter
            functions.Show("TYSS");

        }
    }
    //Functions call By Value
    public class FunctionsByValue
    {
        public void Show(int value)
        {
            value *= value;
            Console.WriteLine("value in calling the functions " + value);
        }
        public static void ain(string[] args)
        {
            int num = 10;
            FunctionsByValue functions = new FunctionsByValue();
            Console.WriteLine("num before calling show functions " + num);
            functions.Show(num);
            Console.WriteLine("value after calling the functions " + num);
        }
    }
    //Functions call By Reference
    public class FunctionsByReference
    {
        public void Show(ref int value)
        {
            value *= value;
            Console.WriteLine("value in calling the functions " + value);
        }
        public static void ain(string[] args)
        {
            int num = 10;
            FunctionsByReference functions = new FunctionsByReference();
            Console.WriteLine("num before calling show functions " + num);
            functions.Show(ref num);
            Console.WriteLine("value after calling the functions " + num);
        }
    }
    //Functions OUT parameter
    public class FunctionsOutParameter
    {
        public void Show(out int value)
        {
            int square = 5;
            value = square;//value=5
            value *= value;//5*5=25
            Console.WriteLine("value in calling the functions " + value);

        }
        public static void ain(string[] args)
        {
            int num = 10;
            FunctionsOutParameter functions = new FunctionsOutParameter();
            Console.WriteLine("num before calling show functions " + num);//10
            functions.Show(out num);//25
            Console.WriteLine("value after calling the functions " + num);//25
        }
    }
}
