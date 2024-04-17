using Proxy.Abstraction;

namespace Proxy.Implementation;

public class BankAccountProxy : IBankAccount
{
    private readonly RealBankAccount _realAccount;
    private readonly string _password;

    public BankAccountProxy(string password)
    {
        _realAccount = new RealBankAccount();
        _password = password;
    }

    public void Deposit(double amount)
    {
        _realAccount.Deposit(amount);
    }

    public bool Withdraw(double amount)
    {
        if (!Authenticate())
        {
            Console.WriteLine("Authentication failed. Access denied.");
            return false;
        }
        
        return _realAccount.Withdraw(amount);
    }

    public double GetBalance()
    {
        if (!Authenticate())
        {
            Console.WriteLine("Authentication failed. Access denied.");
            return 0.0;
        }

        return _realAccount.GetBalance();
    }

    private bool Authenticate()
    {
        Console.WriteLine("Please enter your password:");
        var input = Console.ReadLine();
        return input == _password;
    }
}