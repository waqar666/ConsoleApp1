class Notificationservice
{
  public void OnbalanceIncreased(object sender, BalanceUpdatedEventArgs e)
  {
    try
    {
      BankAccount account = (BankAccount)sender;
      Console.WriteLine($"the new Balance is, {e.NewBalance} ");
      Console.WriteLine($"the Amount increased is, {e.AmtUpdated} ");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"error in OnBalanceUpdated {ex.Message}");
    }

  }
  public void OnbalanceDecreased(object sender, BalanceUpdatedEventArgs e)
  {
    try
    {
      BankAccount account = (BankAccount)sender;
      Console.WriteLine($"the new Balance is, {e.NewBalance} ");
      Console.WriteLine($"the Amount Decreased is, {e.AmtUpdated} ");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"the exception is {ex.Message}");
    }

  }
}
