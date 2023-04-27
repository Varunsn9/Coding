using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    public class Properties
    {
        private string name { get; set; }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Description { get; set; }

        public static void main(String[] args)
        {
            Properties p = new Properties();
            p.Name = "varun";
            Console.WriteLine("Property name is "+p.Name);
           p.Description = "Description";
            Console.WriteLine(p.Description);
        
        }

    }
    public class Pro
    {
        public static void main(String[] args) {
            Properties p = new Properties();
            p.Name = "TYSS";
            Console.WriteLine( p.Name );
        }
    }
}
