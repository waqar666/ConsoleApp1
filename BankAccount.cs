using System.Collections.Generic;

class BankAccount(decimal balance)
{
    private decimal Balance { get; set; } = balance;
    private List<string> logdata = [];
    public delegate void BalanceUpdatedEventHandler(object sender, BalanceUpdatedEventArgs e);
    public event BalanceUpdatedEventHandler? BalanceIncreased;
    public event BalanceUpdatedEventHandler? BalanceDecreased;
    public void AddAmount(decimal amount)
    {
        decimal oldbal = Balance;
        this.Balance += amount;
        if (amount > 0)
        {
            OnbalanceIncreased(new BalanceUpdatedEventArgs(oldbal, Balance, amount));
            logdata.Add($"the old balance was {oldbal}, the new balance is {Balance}, the amount added is {amount}");
        }
        else
        {
            if (amount < 0)
            {
                OnbalanceDecreased(new BalanceUpdatedEventArgs(oldbal, Balance, amount));
                logdata.Add($"the old balance was {oldbal}, the new balance is {Balance}, the amount deducted is {amount}");
            }
        }
    }
    public void printlog()
    {
        foreach (var logdata in logdata)
        {
            Console.WriteLine(logdata);
        }
    }
    //  public void DeleteAmount(decimal amount)
    //  {
    //     Balance -= amount;
    //     OnbalanceChanged(new BalanceUpdatedEventArgs(Balance));
    //    }
    public decimal GetBalance() => Balance;
    protected virtual void OnbalanceIncreased(BalanceUpdatedEventArgs e)
    {
        BalanceIncreased?.Invoke(this, e);
    }
    protected virtual void OnbalanceDecreased(BalanceUpdatedEventArgs e)
    {
        BalanceDecreased?.Invoke(this, e);
    }
}

