using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.LINQ_LanguageIntegratedQuery
{
    public class Car
    {
        public string CarName { get; set; } 
        public string CarId { get; set; }
        public int CarPrice { get; set; }
    }
    public class DataStoring
    {

        public static void main()
        {
            List<Car> list = CareDetails();
            var data = from theCar in list
                       where theCar.CarPrice < 25000
                       orderby theCar.CarName
                       select theCar;
            Console.WriteLine("===================");
            var dat = from theCar in list
                      where theCar.CarName !="audi"
                      select theCar;
           foreach(var item in dat)
            {
                Console.WriteLine(item.CarName + " " + item.CarId + " "+item.CarPrice);
            }
            Console.WriteLine("========================");

            foreach ( var item in data )
            {
                Console.WriteLine( item.CarName + " " + item.CarId + " " + item.CarPrice + " " );
            }
        }
        private static List<Car> CareDetails() 
        {
            return new List<Car>
            { {new Car(){ CarId="A1" , CarName="audi" , CarPrice=10000 } },
                { new Car(){CarId="A2" , CarName="BMW" , CarPrice=20000 } },
                { new Car(){CarId="A1" , CarName="audi" , CarPrice=30000 } }
            };
        }
    }
}
