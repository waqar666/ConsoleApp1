class BalanceUpdatedEventArgs : EventArgs
{
    private decimal NewBalance { get; set; }
    public BalanceUpdatedEventArgs(decimal newbalance)
    {
        NewBalance = newbalance;
    }
}