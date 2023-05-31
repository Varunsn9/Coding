using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Constructors
{
    internal class InstanceConstructor
    {
        string message;
        public InstanceConstructor() {
       InstanceConstructor instanceConstructor = new InstanceConstructor("String MSG");
            //creating the instance inside the constructor
            Console.WriteLine(instanceConstructor.message);
        }
        public InstanceConstructor(string message) {
            this.message=message;
        }
    }
    public class InstanceMain
    {
        public static void main()
        {
            InstanceConstructor instanceConstructor = new InstanceConstructor();
        }
    }
}
