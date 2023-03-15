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
        public static void aain(String[] args)
        {
            Person person = new Person();
            person.Name = "TYSS";
            Console.WriteLine(person.Name);
            Console.WriteLine(DayOfWeek.Monday);
        }
    }
}

