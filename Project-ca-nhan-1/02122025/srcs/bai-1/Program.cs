using System.Data;

namespace bai_1
{
    public class BankAccount()
    {
        private int balance;

        public int getBalance()
        {
            return balance;
        }
        
        private void setBalance(int amount)
        {
            balance = amount;
        }

        public void Deposit()
        {
            int balance = getBalance();
            int amount;

            Console.WriteLine("Deposit Amount: ");
            amount = Convert.ToInt32(Console.ReadLine());

            if (amount < 0)
            {
                Console.WriteLine("Amount not lower than 0");
            }
            else
            {
                setBalance(amount);
                Console.WriteLine($"Update balance successful: +{amount}$");
                Console.WriteLine($"New balance: {getBalance()}$");
            }
        }

        public void Withdraw()
        {
            int balance = getBalance();
            int amount;

            Console.WriteLine("Withdraw Amount: ");
            amount = Convert.ToInt32(Console.ReadLine());

            if(amount < 0 || amount > balance)
            {
                Console.WriteLine("Your transaction failed");
            }
            else
            {
                balance -= amount;
                setBalance(balance);
                Console.WriteLine("Your transaction successful");
                Console.WriteLine($"New balance: {getBalance()}$");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine($"Current balance: {account.getBalance()}$");
            account.Deposit();
            account.Withdraw();

        }
    }
}
