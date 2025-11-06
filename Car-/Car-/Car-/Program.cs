namespace Car_
{
    internal class Program
    {
        public CarManage CarManage = new CarManage();
        static void Main(string[] args)
        {
            Console.WriteLine("Car Sale");
            Console.WriteLine("Rent a car");
            Console.WriteLine("Bank");

            string opChoice = Console.ReadLine();


            switch (opChoice)
            {
                case "1":
                    SaleACar();
                    break;
                case "2":
                    //RentACar();
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Dogru secim et(1-6)");
                    break;
            }


        }

        static void SaleACar()
        {

            while (true)
            {
                Console.WriteLine("1.Masin elave et");
                Console.WriteLine("2.Masinlara bax");
                Console.WriteLine("3.Masini sil");
                Console.WriteLine("4.Masinlari filtrle");
                Console.WriteLine("5.Masinlari cesidle");
                Console.WriteLine("6.Masin sat");
                Console.WriteLine("7.Cixis");

                string choice = Console.ReadLine();



                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Masin elave edin: ");

                        CarManage.AddCar();
                        break;
                    case "2":
                        Console.WriteLine("Masinlarin siyahisi: ");
                        CarManage.GetAll();
                        break;
                    case "3":
                        Console.WriteLine("Silinecek Masinin id-si yaz: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        CarManage.Delete(id);
                        break;
                    case "4":
                        Console.WriteLine("Il daxil edin: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        CarManage.Filter(year);
                        break;
                    case "5":
                        Console.WriteLine("Qiymete gore artan cesidler.");
                        CarManage.OrderByCost();
                        break;
                    case "6":
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Dogru secim et(1-6)");
                        break;
                }
            }
           

        }
        //static void RentACar()
        //{
        //    Console.WriteLine("1.Masin elave et");
        //    Console.WriteLine("2.Masinlara bax");
        //    Console.WriteLine("3.Masini sil");
        //    Console.WriteLine("4.Masinlari filtrle");
        //    Console.WriteLine("5.Masinlari cesidle");
        //    Console.WriteLine("6.Masin icareye ver");

        //    string choice = Console.ReadLine();



        //    switch (choice)
        //    {
        //        case "1":
        //            Console.WriteLine("Masin elave edin: ");

        //            AddCar();
        //            break;
        //        case "2":
        //            CarManage.GetAll();
        //            break;
        //        case "3":
        //            Console.WriteLine("Silinecek Masinin id-si yaz: ");
        //            int id = Convert.ToInt32(Console.ReadLine());
        //            CarRepo.Delete(id);
        //            break;
        //        case "4":
        //            break;
        //        case "5":
        //            break;
        //        case "6":
        //            break;
        //        default:
        //            Console.WriteLine("Dogru secim et(1-6)");
        //            break;
        //    }

        //}
    }
}
