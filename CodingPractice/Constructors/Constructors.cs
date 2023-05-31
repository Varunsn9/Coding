using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Constructors
{
    internal class Constructors
    {
        string var;
        int car;
        static int price;
        static bool Staticbool;
        static double finalCost;
        private Constructors() { }
        public Constructors(string value)//constructor with parameter 
        {

            Var = value;
            Console.WriteLine(Var);
            var car = new Constructors(10);
            Console.WriteLine(car.car);
            Console.WriteLine("this is a static price " + price);
            Console.WriteLine("the static field or a variable which is not initilized so the default value of a bool is " + Staticbool);

        }
        static Constructors()//static constructor are parameterless constructor
        {
            price = 1000;
        }

        public Constructors(int car) => this.car = car;
        public string Var
        {
            get => var;
            set => var = value;
        }
    }
    public struct StructType
    {
       

        
    }
    public class Con
    {
        public static void main()
        {

            Constructors constructors = new Constructors(" this is a parameterized constructor ");
            //new Constructors();   //inaccessible due to its protection level//private constructor
            
        }
    }
}
