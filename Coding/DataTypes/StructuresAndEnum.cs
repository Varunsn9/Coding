using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.DataTypes
{
    public struct Person
    {
        public string Name;
        public int Age;
        public string Gender;
    }
    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public class StructuresAndEnum
    {
       static string name="varun";
        public static void main(String[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.Name);
            person.Name = "TYSS";
            Console.WriteLine(person.Name);
            Console.WriteLine(DayOfWeek.Monday);

            Console.WriteLine(name.Length);
        }
    }
}

