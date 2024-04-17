using Proxy.Abstraction;

namespace Proxy.Implementation;

public class RealBankAccount : IBankAccount
{
    private double _balance;

    public RealBankAccount()
    {
        _balance = 0.0;
    }

    public void Deposit(double amount)
    {
        _balance += amount;
    }

    public bool Withdraw(double amount)
    {
        if (!(amount <= _balance)) return false;
        
        _balance -= amount;
        return true;
    }

    public double GetBalance()
    {
        return _balance;
    }
}