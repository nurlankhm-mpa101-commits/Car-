namespace Car_.Entities
{
    public class BankAccount
    {

        public decimal Balance;


        public BankAccount(decimal balance)
        {
            Balance = balance;

        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (Balance < amount)
            {
                Console.WriteLine("Balansinizda kifayet mebleg yoxdur!");
                return false;
            }
            Balance -= amount;
            return true;
        }



    }
}
