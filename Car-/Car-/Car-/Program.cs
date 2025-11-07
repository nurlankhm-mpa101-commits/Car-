using Car_.Entities;

namespace Car_
{
    internal class Program
    {
        public CarManage CarManage = new CarManage();
        static void Main(string[] args)
        {
            BankAccount bankAccount = BankOperation();


           
            while (true)
            {
                Console.WriteLine("1.Bank");
                Console.WriteLine("2.Rent a car");
                Console.WriteLine("3.Car Sale");
                Console.WriteLine("4.Cixis");

                string opChoice = Console.ReadLine();
                switch (opChoice)
                {
                    case "1":
                        BankAccountOperation(bankAccount);
                        break;
                    case "2":
                        RentACar(bankAccount);
                        break;
                    case "3":
                        SaleACar(bankAccount);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Dogru secim et(1-4)");
                        break;
                }
            }



        }

        public static void BankAccountOperation(BankAccount bankAccount)
        {
            Console.WriteLine($"Adiniz: {bankAccount.Name}, Balance: {bankAccount.Balance}");
        }

        public static BankAccount BankOperation()
        {
            Console.WriteLine("Adinizi daxil edin: ");
            string name = Console.ReadLine();
            Console.WriteLine("Balansinizi daxil edin: ");
            int balance = Convert.ToInt32(Console.ReadLine());

            BankAccount bankAccount = new BankAccount(name, balance);
            return bankAccount;

        }

        static void SaleACar(BankAccount bankAccount)
        {
           
            while (true)
            {

                Console.WriteLine("1.Masin elave et");
                Console.WriteLine("2.Masinlara bax");
                Console.WriteLine("3.Masini sil");
                Console.WriteLine("4.Masinlari filtrle");
                Console.WriteLine("5.Masinlari cesidle");
                Console.WriteLine("6.Masin Sat:");
                Console.WriteLine("7.Cixis");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Masin elave edin: ");
                        CarManage.AddCar(bankAccount, false);
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
                        CarManage.OrderByCost(false);
                        break;
                    case "6":
                        Console.WriteLine("Satmaq istediyiniz masinin id -ni daxil edin. ");
                        int carId = Convert.ToInt32((Console.ReadLine()));
                        CarManage.GetById(carId, bankAccount);
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Dogru secim et(1-7)");
                        break;
                }
            }


        }
        public static void RentACar(BankAccount bankAccount)
        {

            while (true)
            {
                Console.WriteLine("1.Masin elave et");
                Console.WriteLine("2.Masinlara bax");
                Console.WriteLine("3.Masini sil");
                Console.WriteLine("4.Masinlari filtrle");
                Console.WriteLine("5.Masinlari cesidle");
                Console.WriteLine("6.Masin icareye ver");
                Console.WriteLine("7.Cixis");

                string choice = Console.ReadLine();



                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Masin elave edin: ");
                        CarManage.AddCar(bankAccount, true);
                        break;
                    case "2":
                        CarManage.GetRentAll();
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
                        CarManage.OrderByCost(true);
                        break;
                    case "6":
                        Console.WriteLine("Rent ucun ID: ");
                        int carId = Convert.ToInt32((Console.ReadLine()));
                        CarManage.RentCar(carId);
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Dogru secim et(1-6)");
                        break;
                }

            }
            

        }
    }
}
