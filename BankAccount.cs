class BankAccount(decimal balance)
{
    private decimal Balance { get; set; } = balance;
    public delegate void BalanceUpdatedEventHandler(object sender, BalanceUpdatedEventArgs e);
    public event BalanceUpdatedEventHandler? BalanceUpdated;

    public void AddAmount(decimal amount)
    {
        Balance += amount;
        OnbalanceChanged(new BalanceUpdatedEventArgs(Balance));
    }
    public void DeleteAmount(decimal amount)
     {
        Balance -= amount;
        OnbalanceChanged(new BalanceUpdatedEventArgs(Balance));
       }
    public decimal GetBalance() => Balance;
    protected virtual void OnbalanceChanged(BalanceUpdatedEventArgs e)
    { 
        BalanceUpdated?.Invoke(this, e);
    }
}
