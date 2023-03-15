using Coding.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.ObjectAndClass
{
    public class ThisExample
    {
        public int id;
        public String name;
        public float salary;
        public ThisExample(int id, String name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }

    class TestEmployee
    {
        public static void aain(string[] args)
        {
            ThisExample e1 = new ThisExample(101, "Sonoo", 890000f);
            ThisExample e2 = new ThisExample(102, "Mahesh", 490000f);
            e1.display();
            e2.display();
        }
    }
}
