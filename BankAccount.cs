class BankAccount(decimal balance)
{
    private decimal Balance { get; set; } = balance;
    public delegate void BalanceUpdatedEventHandler(object sender, EventArgs e);
    public event BalanceUpdatedEventHandler? BalanceUpdated;
    public void AddAmount(decimal amount)
    {
        Balance += amount;
        OnbalanceChanged(EventArgs.Empty);
    }
    public decimal GetBalance() => Balance;
    protected virtual void OnbalanceChanged(EventArgs e)
    { 
        BalanceUpdated?.Invoke(this, e);
    }
}
