using Lab5.Infrastructure.DataAccess.Repository;
using Lab5.Presentation.Console.Atm;
using Lab5.Presentation.Console.Console;

namespace ConsoleApp;

public static class Program
{
    public static void Main()
    {
        const string connectionString = "User ID=postgres;Password=postgres;Host=localhost;Port=5433;Database=postgres";

        var database = new AccountRepository(connectionString);
        var atm = new AutomaticTellerMachine(database);
        const string systemPassword = "admin";
        var console = new ConsoleInputOutput(atm, systemPassword, database);

        console.Run();
    }
}