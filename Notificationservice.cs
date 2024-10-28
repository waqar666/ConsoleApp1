class Notificationservice
{
    public void OnbalanceUpdated(object sender, BalanceUpdatedEventArgs e)
    {
        BankAccount account = (BankAccount)sender;
       // decimal bal = account.GetBalance();
        //Console.WriteLine($"the current balance is, {bal} ");
        Console.WriteLine($"the new amount is, {e.NewBalance} ");
    }
}
