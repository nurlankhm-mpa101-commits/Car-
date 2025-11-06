using Car_.Entities;

namespace Car_;

public class CarManage
{
    public static List<Car> Cars { get; set; }
    public CarManage()
    {

    }
    public static void Delete(int id)
    {
        foreach (var item in Cars)
        {
            if (item.Id == id)
            {
                Cars.Remove(item);
            }
        }
    }

    public static void OrderByCost()
    {
        List<Car> orderedCars = Cars.OrderBy(x => x.Cost).ToList();
        foreach (var item in orderedCars)
        {
            Console.WriteLine(item);
        }
    }


    public static void AddCar()
    {
        Console.WriteLine("Brand elave edin");
        string brand = Console.ReadLine();
        Console.WriteLine("Model elave edin");
        string model = Console.ReadLine();
        Console.WriteLine("Year elave edin");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Rent ucundurse true");
        bool isRent = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Cost daxil edin:");
        int cost = Convert.ToInt32(Console.ReadLine());
        Car car = new Car(brand, model, year, isRent, cost);
        Cars.Add(car);
        Console.WriteLine("Car added successfully");



    }

    public static void Filter(int year)
    {
        List<Car> filteredCar = Cars.Where(c => c.Year > year).ToList();
        foreach (Car car in filteredCar)
        {
            Console.WriteLine($"{car.Brand}");
        }




    }



}
