namespace Car_.Entities;

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


}
