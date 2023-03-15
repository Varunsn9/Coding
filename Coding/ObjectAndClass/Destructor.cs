using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Coding.ObjectAndClass
{
    //Destructor is not working
    public class Destructor 
    {
        public Destructor()
        {
            Console.WriteLine("this is a Constructor");
            //            MessageBox.Show("this is a Constructor");
        }
        ~Destructor()
        {
            Console.WriteLine("this is a Destructor");
             // MessageBox.Show("this is a Destructor");
        }
    }

    //Enums
    public class EnumExample
    {
        public enum Days { sun, mon, tue, wed, thr, fri, sat }

        public static void min(String[] args)
        {
            Destructor destructor = new Destructor();

            foreach(Days s in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(s);
            }
            int a = (int)Days.sat;
            Console.WriteLine(a);
        }
    }
}
