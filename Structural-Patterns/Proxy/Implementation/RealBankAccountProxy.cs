using Proxy.Abstraction;

namespace Proxy.Implementation;

// The Proxy
public class BankAccountProxy : IBankAccount
{
    private RealBankAccount _realAccount;
    private string _password;

    public BankAccountProxy(string password)
    {
        _realAccount = new RealBankAccount();
        _password = password;
    }

    public void Deposit(double amount)
    {
        _realAccount.Deposit(amount); // Direct pass-through
    }

    public bool Withdraw(double amount)
    {
        if (Authenticate())
        {
            return _realAccount.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Authentication failed. Access denied.");
            return false;
        }
    }

    public double GetBalance()
    {
        if (Authenticate())
        {
            return _realAccount.GetBalance();
        }
        else
        {
            Console.WriteLine("Authentication failed. Access denied.");
            return 0.0;
        }
    }

    private bool Authenticate()
    {
        // Simulate an authentication check
        Console.WriteLine("Please enter your password:");
        string input = Console.ReadLine();
        return input == _password;
    }
}