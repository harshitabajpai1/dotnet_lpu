using NUnit.Framework;
using System;

namespace nUnit_Assessment;

public class UnitTest
{
    [Test]
    public void Test_Deposit_ValidAmount()
    {
        var acc = new Program(100m);
        acc.Deposit(50m);
        Assert.That(acc.Balance, Is.EqualTo(150m));

    }

    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        var acc = new Program(100m);
        var ex = Assert.Throws<Exception>(() => acc.Deposit(-10m));
        Assert.That(ex.Message, Is.EqualTo("Deposit amount cannot be negative"));

    }

    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        var acc = new Program(200m);
        acc.Withdraw(50m);
        Assert.That(acc.Balance, Is.EqualTo(150m));

    }

    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        var acc = new Program(100m);
        var ex = Assert.Throws<Exception>(() => acc.Withdraw(200m));
        Assert.That(ex.Message,Is.EqualTo("Insufficient funds."));
    }
}
