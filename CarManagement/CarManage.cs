using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManagement.Entities;

namespace CarManagement
{
    public class CarManage
    {
        public static List<Car> Cars { get; set; } = new List<Car>();
        public static void AddCar()
        {
            Console.WriteLine("Brand elave edin");
            string brand=Console.ReadLine();
            Console.WriteLine("Model elave edin");
            string model=Console.ReadLine();
            Console.WriteLine("Year elave edin");
            int year=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rent ucundurse true");
            bool isRent=Convert.ToBoolean(Console.ReadLine());
            Car car = new Car(brand,model,year,isRent);
            Cars.Add(car);
            Console.WriteLine("Car added successfully");
            


        }
        public static void Filter(int year)
        {
            List<Car> filteredCar=Cars.Where(c => c.Year > year).ToList();
            foreach (Car car in filteredCar) 
            {
                Console.WriteLine($"{car.Brand}");
            }




        }
    }
}
