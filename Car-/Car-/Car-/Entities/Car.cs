namespace Car_.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Cost { get; set; }
        public int Year { get; set; }
        public bool ForRent { get; set; }
        public List<Car> Cars { get; set; }

        public Car(int id, string brand, string model, int year, bool forRent, int cost)
        {
            Brand = brand;
            Model = model;
            Year = year;
            ForRent = forRent;
            Cost = cost;
            Id = id;
        }

    }
}
