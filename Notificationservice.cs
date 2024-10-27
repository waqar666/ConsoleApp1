class Notificationservice
{
    public void OnbalanceUpdated(object sender, EventArgs e)
    {
        BankAccount account = (BankAccount)sender;
        decimal bal = account.GetBalance();
        Console.WriteLine($"the current balance is, {bal} ");
    }
}
