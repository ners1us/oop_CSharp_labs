using Lab5.Application.Abstractions;
using Lab5.Application.Exceptions;
using Lab5.Application.Models;
using Lab5.Infrastructure.DataAccess.Repository;
using NSubstitute;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests;

public class TestsForFifthLab
{
    [Fact]
    public void WithdrawalWithSufficientBalanceShouldUpdateBalanceAndSaveAccount()
    {
        // Arrange
        IAccountRepository? mockRepository = Substitute.For<IAccountRepository>();
        int number = 4444;
        int pin = 1234;
        double balance = 100;
        var account = new Account(number, pin, balance);
        int withdrawalAmount = 50;
        mockRepository.FindAccount(account.Number).Returns(account);
        var service = new MockAccountRepository(mockRepository);

        // Act
        service.WithdrawMoney(account.Number, withdrawalAmount);

        // Assert
        mockRepository.Received(1).UpdateAccount(Arg.Is<Account>(a => a.Balance == 50));
        mockRepository.Received(1).SaveTransaction(account.Number, "Withdrawal", withdrawalAmount);
    }

    [Fact]
    public void WithdrawalWithInsufficientBalanceShouldThrowException()
    {
        // Arrange
        IAccountRepository? mockRepository = Substitute.For<IAccountRepository>();
        int number = 5555;
        int pin = 1234;
        double balance = 50;
        var account = new Account(number, pin, balance);
        mockRepository.FindAccount(account.Number).Returns(account);
        int withdrawalAmount = 100;
        var service = new MockAccountRepository(mockRepository);

        // Assert & Act
        Assert.Throws<InsufficientBalanceException>(() => service.WithdrawMoney(account.Number, withdrawalAmount));
        mockRepository.DidNotReceive().UpdateAccount(Arg.Any<Account>());
        mockRepository.DidNotReceive().SaveTransaction(Arg.Any<int>(), Arg.Any<string>(), Arg.Any<double>());
    }

    [Fact]
    public void DepositShouldUpdateBalanceAndSaveAccount()
    {
        // Arrange
        IAccountRepository? mockRepository = Substitute.For<IAccountRepository>();
        int number = 7777;
        int pin = 1234;
        double balance = 100;
        var account = new Account(number, pin, balance);
        mockRepository.FindAccount(account.Number).Returns(account);
        int depositAmount = 50;
        var service = new MockAccountRepository(mockRepository);

        // Act
        service.DepositMoney(account.Number, depositAmount);

        // Assert
        mockRepository.Received(1).UpdateAccount(Arg.Is<Account>(a => a.Balance == 150));
        mockRepository.Received(1).SaveTransaction(account.Number, "Deposit", depositAmount);
    }
}