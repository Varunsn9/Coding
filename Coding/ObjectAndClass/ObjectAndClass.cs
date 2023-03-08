using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.ObjectAndClass
{
    public class ObjectAndClass
    {
        int id;
        string name;
        public ObjectAndClass()
        {
            Console.WriteLine(id + " " + name);
        }
        public ObjectAndClass(int id, string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine(id + " " + name);
        }

        public static void aain(string[] args)
        {
            ObjectAndClass objectAndClass = new ObjectAndClass();
            objectAndClass.id = 1;
            objectAndClass.name = "varun";
            Console.WriteLine(objectAndClass.id + " " + objectAndClass.name);
            ObjectAndClass objectAndClass1 = new ObjectAndClass(2, "yusuf");


        }
    }
}
