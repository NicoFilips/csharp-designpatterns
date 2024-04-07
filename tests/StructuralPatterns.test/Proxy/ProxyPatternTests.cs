using NUnit.Framework;
using System;
using System.IO;
using Proxy.Implementation;

namespace StructuralPatterns.test.Proxy;

public class ProxyPatternTests
{
    private StringWriter _stringWriter;
    private StringReader _stringReader;
    private string _correctPassword = "correct_password";
    private string _wrongPassword = "wrong_password";
    private BankAccountProxy _proxyWithCorrectPassword;
    private BankAccountProxy _proxyWithWrongPassword;

    [SetUp]
    public void Setup()
    {
        _stringWriter = new StringWriter();
        Console.SetOut(_stringWriter);

        _proxyWithCorrectPassword = new BankAccountProxy(_correctPassword);
        _proxyWithWrongPassword = new BankAccountProxy(_wrongPassword);
    }

    
    [Test]
    public void Withdraw_WithCorrectPassword_ShouldAllow()
    {
        // Arrange
        _proxyWithCorrectPassword.Deposit(100.0);
        SetConsoleInput(_correctPassword);

        // Act
        bool withdrawResult = _proxyWithCorrectPassword.Withdraw(50.0);

        SetConsoleInput(_correctPassword);
        double balance = _proxyWithCorrectPassword.GetBalance();

        // Assert
        Assert.IsTrue(withdrawResult);
        Assert.That(balance, Is.EqualTo(50.0));
    }

    [Test]
    public void Withdraw_WithWrongPassword_ShouldDeny()
    {
        // Arrange
        _proxyWithCorrectPassword.Deposit(100.0);
        SetConsoleInput(_wrongPassword);

        // Act
        bool withdrawResult = _proxyWithWrongPassword.Withdraw(50.0);

        SetConsoleInput(_wrongPassword);
        double balance = _proxyWithWrongPassword.GetBalance();

        // Assert
        Assert.IsFalse(withdrawResult);
        Assert.That(balance, Is.EqualTo(0));
    }
    
    private void SetConsoleInput(string input)
    {
        if (_stringReader != null)
        {
            _stringReader.Close();
        }
    
        _stringReader = new StringReader(input);
        Console.SetIn(_stringReader);
    }

    [TearDown]
    public void TearDown()
    {
        _stringWriter.Close();
        _stringReader.Close();
        Console.SetOut(Console.Out);
        Console.SetIn(Console.In);
    }
}