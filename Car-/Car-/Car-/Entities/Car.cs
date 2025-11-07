namespace Car_.Entities
{
    public class Car
    {
        public static int Id { get; set; } 
        public int DefaultId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Cost { get; set; }
        public int Year { get; set; }
        public bool ForRent { get; set; }
        public List<Car> Cars { get; set; }

        public Car( string brand, string model, int year, bool forRent, int cost)
        {

            Brand = brand;
            Model = model;
            Year = year;
            ForRent = forRent;
            Cost = cost;
            Id ++;
            DefaultId= Id;
        }

    }
}
