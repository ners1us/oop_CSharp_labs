using System.Collections.ObjectModel;
using Lab5.Application.Models;

namespace Lab5.Application.Abstractions;

public interface IAccountRepository
{
    void SaveAccount(Account? account);
    Account? FindAccount(int accountNumber);
    void UpdateAccount(Account? account);
    void SaveTransaction(int accountNumber, string operation, double amount);
    void ChangePin(int accountNumber, int newPin);
    ReadOnlyCollection<string> GetTransactionHistory(int accountNumber);
    bool AccountExists(int accountNumber);
}
