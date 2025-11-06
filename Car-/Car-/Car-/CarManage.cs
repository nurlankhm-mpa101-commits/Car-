using Car_.Entities;

namespace Car_;

public class CarManage
{
    public static List<Car> Cars { get; set; } = new List<Car>();
    public CarManage()
    {
    }
    public static void Delete(int id)
    {
        int removedCount = Cars.RemoveAll(c => c.Id == id);
        if (removedCount > 0)
            Console.WriteLine($"Car with Id={id} deleted successfully.");
        else
            Console.WriteLine($"Car with Id={id} not found.");
    }

    public static void OrderByCost()
    {
        List<Car> orderedCars = Cars.OrderBy(x => x.Cost).ToList();
        foreach (var item in orderedCars)
        {
            Console.WriteLine($"{item.Id} {item.Brand} {item.Model} {item.Year} {item.Cost}");
        }
    }


    public static void AddCar()
    {
        Console.WriteLine("Id elave edin:");
        int id = Convert.ToInt32(Console.ReadLine());
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
        Car car = new Car(id, brand, model, year, isRent, cost);
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

    public static void GetAll()
    {

        foreach (var car in Cars)
        {
            Console.WriteLine($"Id:{car.Id},Brand:{car.Brand}, Model:{car.Model},Year:{car.Year}");
        }
    }


    public bool RentCar(int carId)
    {
        // İlgili arabayı bul
        Car carToRent = Cars.FirstOrDefault(c => c.Id == carId);

        if (carToRent == null)
        {
            Console.WriteLine("Araba bulunamadı!");
            return false;
        }

        if (!carToRent.ForRent)
        {
            Console.WriteLine("Bu araba kiralanamaz!");
            return false;
        }

        // Arabayı kiralandı olarak işaretle
        carToRent.ForRent = false;
        Console.WriteLine($"{carToRent.Brand} {carToRent.Model} başarıyla kiralandı!");
        return true;
    }



}
