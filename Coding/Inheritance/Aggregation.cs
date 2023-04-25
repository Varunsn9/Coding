using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Inheritance
{
    public class Aggregation
    {
        public static void main(String[] args)
        {
            Address address=new Address("Bangalore","Karnataka","560076");
            Employee employee = new Employee( 1, "varun", address);
            employee.Display();
        }

    }
    public class Employee
    {
        public int id;
        public string name; 
        public Address address;

        public Employee(int id,string name,Address address) 
        { 
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void Display()
        {
            Console.WriteLine( name+" "+id+" "+ address.city+" "+address.state+" "+address.pincode );
        }
    
    }

    public class Address
    {
        public string city, state, pincode;

        public Address(string city, string state, string pincode)
        {
            this.city = city;
            this.state = state;
            this.pincode = pincode;
        }
    }
}
