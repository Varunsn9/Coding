using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Coding.ObjectAndClass
{
    public class StructuresAndClass
    {
        public static void aain(string[] args)
        {
            StructuresR structuresR=new StructuresR();
            Console.WriteLine(structuresR.AreaOfRectangle(5,10));
        }
    }
    public struct StructuresR
    {
        public StructuresR() 
        {
            Console.WriteLine("Struct");
        }

        public int AreaOfRectangle(int length, int width)
        {
            int area = length * width;
            return area;
        }
    }
}
