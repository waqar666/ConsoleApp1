class BalanceUpdatedEventArgs(decimal previousbalance, decimal newbalance, decimal amtupdated) : EventArgs
{
    public decimal NewBalance { get; } = newbalance;
    public decimal PreviousBalance { get; } = previousbalance;
    public decimal AmtUpdated { get; } = amtupdated;

}