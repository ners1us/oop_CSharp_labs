using Lab5.Application.Abstractions;
using Lab5.Application.Exceptions;
using Lab5.Application.Models;

namespace Lab5.Infrastructure.DataAccess.Repository;

public class MockAccountRepository
{
    private readonly IAccountRepository _repository;

    public MockAccountRepository(IAccountRepository repository)
    {
        _repository = repository;
    }

    public void WithdrawMoney(int accountNumber, double amount)
    {
        ArgumentNullException.ThrowIfNull(accountNumber);
        ArgumentNullException.ThrowIfNull(amount);

        Account? account = _repository.FindAccount(accountNumber);
        if (account == null || account.Balance < amount)
        {
            throw new InsufficientBalanceException();
        }

        var updatedAccount = new Account(
            account.Number,
            account.Pin,
            account.Balance - amount);

        _repository.UpdateAccount(updatedAccount);
        _repository.SaveTransaction(accountNumber, "Withdrawal", amount);
    }

    public void DepositMoney(int accountNumber, double amount)
    {
        Account? account = _repository.FindAccount(accountNumber);

        ArgumentNullException.ThrowIfNull(account);

        var updatedAccount = new Account(
            account.Number,
            account.Pin,
            account.Balance + amount);

        _repository.UpdateAccount(updatedAccount);
        _repository.SaveTransaction(accountNumber, "Deposit", amount);
    }
}
