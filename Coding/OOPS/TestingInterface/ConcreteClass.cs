using Coding.OOPS.Interface;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.OOPS.TestingInterface
{
    public class ConcreteClass : IOne ,ITwo
    {
        public void Display()
        {
            Console.WriteLine("this is the implemented method");
        }

        public virtual void Sound()
        {
            System.Console.WriteLine("animals makes sound");
        }
        public static void main(string[] args)
        {
            IOne io = new ConcreteClass();
           // io.Display("-----------------------------");
        }

        public void Sounds()
        {
            Console.WriteLine("This is a concrete class");
        }

        public void Name()
        {
            Console.WriteLine( "Class Name is ConcreteClass" );
        }
    }
    public class Dog : ConcreteClass, IOne ,ITwo
    {
        public void Name()
        {
            Console.WriteLine( "Name of the class is Dog" );
        }
        public override void Sound()
        {
            System.Console.WriteLine("dog barks");
        }

        public void Sounds()
        {
            System.Console.WriteLine("this is a dog Class");
        }
    }
    public class Cat : ConcreteClass , IOne
    {
        public override void Sound()
    {
        System.Console.WriteLine("cat meaws");
    }

        public void Sounds()
        {
            System.Console.WriteLine("this is a cat Class");
        }
    }
    public class Sounds 
    {
        public static void main(string[] args)
        {
            ConcreteClass cs=new ConcreteClass();
            cs.Sound();
            Console.WriteLine("-----------------------------");
            
            ConcreteClass sd=new Dog();
            sd.Sound();
            Console.WriteLine("-------------------------------");

            ConcreteClass sc=new Cat();
            sc.Sound();
            Console.WriteLine("-------------------------------");
            
            IOne io=new ConcreteClass();
            io.Sounds();
            Console.WriteLine("-------------------------------");
            
            IOne ic = new Cat();
            ic.Sounds();
            Console.WriteLine("-------------------------------");
            
            IOne id=new Dog();
            id.Sounds();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");

            ITwo itd =new Dog();
            itd.Name();
        
        }
    }

}
