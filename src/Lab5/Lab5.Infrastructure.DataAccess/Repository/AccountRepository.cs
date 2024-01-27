using System.Collections.ObjectModel;
using System.Globalization;
using Lab5.Application.Abstractions;
using Lab5.Application.Models;
using Npgsql;

namespace Lab5.Infrastructure.DataAccess.Repository;

public class AccountRepository : IAccountRepository
{
    private readonly string _connectionString;

    public AccountRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void SaveAccount(Account? account)
    {
        ArgumentNullException.ThrowIfNull(account);

        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();
        using var command = new NpgsqlCommand("INSERT INTO accounts (account_number, pin, balance) VALUES (@account_number, @pin, @balance)", connection);
        command.Parameters.AddWithValue("account_number", account.Number);
        command.Parameters.AddWithValue("pin", account.Pin);
        command.Parameters.AddWithValue("balance", account.Balance);
        command.ExecuteNonQuery();
    }

    public Account? FindAccount(int accountNumber)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();
        using var command = new NpgsqlCommand("SELECT * FROM accounts WHERE account_number = @account_number", connection);
        command.Parameters.AddWithValue("account_number", accountNumber);
        using NpgsqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            return new Account(
                reader.GetInt32(reader.GetOrdinal("account_number")),
                reader.GetInt32(reader.GetOrdinal("pin")),
                reader.GetDouble(reader.GetOrdinal("balance")));
        }

        return null;
    }

    public void SaveTransaction(int accountNumber, string operation, double amount)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();
        using var command = new NpgsqlCommand("INSERT INTO transactions (account_number, operation, amount) VALUES (@account_number, @operation, @amount)", connection);
        command.Parameters.AddWithValue("account_number", accountNumber);
        command.Parameters.AddWithValue("operation", operation);
        command.Parameters.AddWithValue("amount", amount);
        command.ExecuteNonQuery();
    }

    public ReadOnlyCollection<string> GetTransactionHistory(int accountNumber)
    {
        var history = new List<string>();

        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();
        using var command = new NpgsqlCommand("SELECT * FROM transactions WHERE account_number = @account_number", connection);
        command.Parameters.AddWithValue("account_number", accountNumber);
        using NpgsqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            string operation = reader.GetString(reader.GetOrdinal("operation"));
            decimal amount = reader.GetDecimal(reader.GetOrdinal("amount"));
            history.Add($"{operation}: {amount}");
        }

        return history.AsReadOnly();
    }

    public void ChangePin(int accountNumber, int newPin)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();
        using var command = new NpgsqlCommand("UPDATE accounts SET pin = @newPin WHERE account_number = @account_number", connection);
        command.Parameters.AddWithValue("newPin", newPin);
        command.Parameters.AddWithValue("account_number", accountNumber);
        command.ExecuteNonQuery();
    }

    public void UpdateAccount(Account? account)
    {
        ArgumentNullException.ThrowIfNull(account);

        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();
        using var command = new NpgsqlCommand("UPDATE accounts SET pin = @pin WHERE account_number = @account_number", connection);
        command.Parameters.AddWithValue("pin", account.Pin);
        command.Parameters.AddWithValue("account_number", account.Number);
        command.ExecuteNonQuery();

        UpdateBalance(account.Number, account.Balance);
    }

    public bool AccountExists(int accountNumber)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();
        using var command = new NpgsqlCommand("SELECT EXISTS (SELECT 1 FROM accounts WHERE account_number = @account_number)", connection);
        command.Parameters.AddWithValue("account_number", accountNumber);
        bool exists = Convert.ToBoolean(command.ExecuteScalar(), CultureInfo.InvariantCulture);

        return exists;
    }

    private void UpdateBalance(int accountNumber, double newBalance)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();
        using var command = new NpgsqlCommand("UPDATE accounts SET balance = @balance WHERE account_number = @account_number", connection);
        command.Parameters.AddWithValue("balance", newBalance);
        command.Parameters.AddWithValue("account_number", accountNumber);
        command.ExecuteNonQuery();
    }
}