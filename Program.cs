using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter inital amount");
        string? readinput = Console.ReadLine();
        if (decimal.TryParse(readinput, out decimal initialvalue))
        {
            var account1 = new BankAccount(initialvalue);
            var ns = new Notificationservice();
            account1.BalanceIncreased += ns.OnbalanceIncreased;
            account1.BalanceDecreased += ns.OnbalanceDecreased;
            Console.WriteLine($"current balance is {account1.GetBalance()}");
            Console.WriteLine("enter inital amount");
            string? readinput1 = Console.ReadLine();
            if (decimal.TryParse(readinput1, out decimal initialvalue1))
            {
                account1.AddAmount(initialvalue1);
            }

            Console.WriteLine($"current balance is {account1.GetBalance()}");
            Console.WriteLine("log generated");
            account1.printlog();
        }

    }
}