namespace Proxy.Abstraction;

// The component interface
public interface IBankAccount
{
    void Deposit(double amount);
    bool Withdraw(double amount);
    double GetBalance();
}