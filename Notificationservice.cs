class Notificationservice
{
  public void OnbalanceIncreased(object sender, BalanceUpdatedEventArgs e)
  {
    BankAccount account = (BankAccount)sender;
    Console.WriteLine($"the new Balance is, {e.NewBalance} ");
    Console.WriteLine($"the Amount increased is, {e.AmtUpdated} ");
  }
  public void OnbalanceDecreased(object sender, BalanceUpdatedEventArgs e)
  {
    BankAccount account = (BankAccount)sender;
    Console.WriteLine($"the new Balance is, {e.NewBalance} ");
    Console.WriteLine($"the Amount Decreased is, {e.AmtUpdated} ");
  }
}
