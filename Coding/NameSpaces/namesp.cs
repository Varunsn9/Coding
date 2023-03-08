using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.NameSpaces
{
    //public can be accessible  
    public class namesp
    {
        public string name = "varun";
        public void message(string name) {
            Console.WriteLine(name);
        }
    }
    public class NameSp2 {
    
        public static void ain(string[] args)
        {
            namesp sp = new namesp();
            sp.message(sp.name);
        }
    }
    //proctected can be accessible only inside a class
    public class ProtectedClass
    {
        protected string name = "varun";
        protected void message(string name)
        {
            Console.WriteLine(name);
        }
    }
    public class ProtectedClass2 : ProtectedClass 
    {

        public static void main(string[] args)
        {
            ProtectedClass sp = new ProtectedClass();
            //sp.message(sp.name);//in accessible due to protection level//compile time error
        }
    }
    //Internal can be accessible in side an assembly
    public class InternalClass
    {
        internal string name = "varun";
        internal void message(string name)
        {
            Console.WriteLine(name);
        }
    }
    public class InternalClass2
    {

        public static void main(string[] args)
        {
            InternalClass sp = new InternalClass();
            sp.message(sp.name);
        }
    }
    //protected internally can be accessible inside a class and derived class 
    public class ProtectedInternalClass
    {
        protected internal string name = "varun";
        protected internal void message(string name)
        {
            Console.WriteLine(name);
        }
    }
    public class ProtectedInternalClass2
    {
        public static void main(string[] args)
        {
            ProtectedInternalClass sp = new ProtectedInternalClass();
            sp.message(sp.name);
        }
    }
    //Private Access Specifier is used to specify private accessibility to the variable or function.
    //It is most restrictive and accessible only within the body of class in which it is declared
    public class PrivateClass
    {
        private string name = "varun";
        private void message(string name)
        {
            Console.WriteLine(name);
        }
    }
    public class PrivateClass2 : PrivateClass
    {
        public static void Min(string[] args)
        {
            PrivateClass sp = new PrivateClass();
         //   sp.message(sp.name);
        }
    }

}
