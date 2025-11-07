using Car_.Entities;

namespace Car_;

public class CarManage
{
    public static List<Car> Cars { get; set; } = new List<Car>();
    public CarManage()
    {
    }

    public static void GetById(int id, BankAccount bankAccount)
    {
        foreach (var car in Cars)
        {
            if (car.DefaultId == id)
            {
                bankAccount.Deposit(id);
                Delete(id);
                return;
            }

        }

        Console.WriteLine("Bele bir masin yoxdur.");

    }

    public static void Delete(int id)
    {
        int removedCount = Cars.RemoveAll(c => c.DefaultId == id);
        if (removedCount > 0)
            Console.WriteLine($"Car with Id={id} deleted successfully.");
        else
            Console.WriteLine($"Car with Id={id} not found.");
    }

    public static void OrderByCost( bool isRent)
    {
        if (isRent)
        {
            foreach (var car in Cars)
            {
                if (car.ForRent == true)
                {
                    List<Car> orderedCars = Cars.OrderBy(x => x.Cost).ToList();
                    foreach (var item in orderedCars)
                    {
                        Console.WriteLine($"Id: {item.DefaultId} Brand: {item.Brand} Model: {item.Model} Year: {item.Year} Cost: {item.Cost}");
                    }

                }
            }
        }
        else
        {
            foreach (var car in Cars)
            {
                if (car.ForRent == true)
                {
                    List<Car> orderedCars = Cars.OrderBy(x => x.Cost).ToList();
                    foreach (var item in orderedCars)
                    {
                        Console.WriteLine($"Id: {item.DefaultId} Brand: {item.Brand} Model: {item.Model} Year: {item.Year} Cost: {item.Cost}");
                    }

                }
            }

        }
        
     
    }


    public static void AddCar(BankAccount bank, bool forRent)
    {
        Console.WriteLine("Brand elave edin");
        string brand = Console.ReadLine();
        Console.WriteLine("Model elave edin");
        string model = Console.ReadLine();
        Console.WriteLine("Year elave edin");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Cost daxil edin:");
        int cost = Convert.ToInt32(Console.ReadLine());
        Car car = new Car( brand, model, year, forRent, cost);
        if (!bank.Withdraw(car.Cost))
        {
            Console.WriteLine("Kifayet qeder mebleginiz yoxdur.");
            return;
        }

        Cars.Add(car);
        Console.WriteLine("Car added successfully");


    }

    public static void Filter(int year)
    {
        List<Car> filteredCar = Cars.Where(c => c.Year > year).ToList();
        foreach (Car item in filteredCar)
        {
            Console.WriteLine($"Id: {item.DefaultId} Brand: {item.Brand} Model: {item.Model} Year: {item.Year} Cost: {item.Cost}");
        }

    }

    public static void GetAll()
    {
        Console.WriteLine($"Cars for Sell");
        foreach (var car in Cars)
        {
            if (car.ForRent == false)
            {
                Console.WriteLine($"Id:{car.DefaultId},Brand:{car.Brand}, Model:{car.Model},Year:{car.Year}");
            }
        }
    }

    public static void GetRentAll()
    {
        Console.WriteLine($"Cars for Rent");
        foreach (var car in Cars)
        {
            if (car.ForRent == true)
            {
                Console.WriteLine($"Id:{car.DefaultId},Brand:{car.Brand}, Model:{car.Model},Year:{car.Year}");
            }
        }
    }

    public static bool RentCar(int carId)
    {
      
        Car carToRent = Cars.FirstOrDefault(c => c.DefaultId == carId);

        if (carToRent == null)
        {
            Console.WriteLine("Masin tapilmadi.");
            return false;
        }

        if (!carToRent.ForRent)
        {
            Console.WriteLine("Masin kiraye ucun uygun deil.");
            return false;
        }

      
        carToRent.ForRent = false;
        Console.WriteLine($"{carToRent.Brand} {carToRent.Model} ugurla kiraye goturuldu" +
            $"!");
        return true;
    }



}
