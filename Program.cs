using System;
class Program
{
    static void Main()
    {
        BankAccount account1 = new(5000);
        Notificationservice ns = new();
        account1.BalanceUpdated += ns.OnbalanceUpdated;
        decimal bal = account1.GetBalance();
        Console.WriteLine($"current balance is {bal}");
        account1.AddAmount(200);
    }
}