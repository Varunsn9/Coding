using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.OOPS.Interface
{
    public interface IOne
    {
        abstract public void Sounds();

        public abstract void Display();
        

        public void Diplay(string message)
        {
            Console.WriteLine( message );
        }
        
    }
     abstract class AbstractClass : IOne
    {
        public void Display()
        {
            Console.WriteLine( "implementing the display method of IOne" );
        }

        public void Sounds()
        {
           
        }
    }
}
