namespace Car_.Entities
{
    public class BankAccount
    {
        public string Name { get; set; }
        public int Balance;


        public BankAccount(string name, int balance)
        {
            Balance = balance;
            Name = name;
        }

        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine($"Balansiniz artirildi. Balance: {Balance}");
        }

        public bool Withdraw(int amount)
        {
            if (Balance < amount)
            {
                return false;
            }
            Balance -= amount;

            return true;
        }



    }
}
