class BalanceUpdatedEventArgs(decimal newbalance) : EventArgs
{
    public decimal NewBalance { get; } = newbalance;
}