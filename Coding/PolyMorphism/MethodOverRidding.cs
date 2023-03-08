using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.PolyMorphism
{
    public class Pet
    {
        public Pet() {
            Console.WriteLine("Pet");
        }
        public virtual void Name()
        {
            Console.WriteLine("virtual Name()");
        }
    }
    public class Animal : Pet {
        public Animal()
        {
            Console.WriteLine("Animal");
        }
        public override void Name()
        {
            Console.WriteLine("OverRide Name()");
        }
    }

    public class MethodOverRidding
    {
        public static void ain(string[] args) {
            Animal animal = new Animal();
            animal.Name();
        }
    }
}
