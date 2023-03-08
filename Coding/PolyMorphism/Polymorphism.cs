using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Coding.PolyMorphism
{
    
    public class Polymorphism
    {
        public static void ain(String[] args)
        {
            Virtu overRide = new OverRide();
            overRide.Name();
            overRide.show();
        }
    }
    public class Virtu
    {
        public string name = "varun";
        public virtual void Name()
        {
            Console.WriteLine("virtual");
        }
        public void show()
        {
            Console.WriteLine("vir show");
        }
    }
    public class OverRide : Virtu
    {
        public string name = "varun";
        public override void Name()
        {
            Console.WriteLine("OverRide");
        }
        public void show()
        {
            Console.WriteLine("ovr show");
        }
    }
    public class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("drawing...");
        }
    }
    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }

    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle...");
        }

    }
    public class TestPolymorphism
    {
        public static void abain()
        {
            Shape s;
            s = new Shape();
            s.draw();
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();

        }
    }
    public class GOTOClass
    {
        public static void aaain(String[] args)
        {
            int a = 0;

            value:
            
            
            int b = a;
            Console.WriteLine(b);
            if (b < 100)
            {
                a++;
                goto value ;
            }

        }
    }
}
