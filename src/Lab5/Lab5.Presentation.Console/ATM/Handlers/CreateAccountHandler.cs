using Lab5.Application.Abstractions;
using Lab5.Application.Models;

namespace Lab5.Presentation.Console.ATM.Handlers;

public class CreateAccountHandler : AtmOperationHandler
{
    private const double InitialBalance = 0;
    public CreateAccountHandler(IAccountRepository accountRepository)
        : base(accountRepository)
    {
    }

    public override void HandleRequest(AtmRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (request.Operation == "CreateAccount")
        {
            var account = new Account(
                request.AccountNumber,
                request.Pin,
                InitialBalance);

            Database.SaveAccount(account);
            System.Console.WriteLine("Account created successfully");
        }
        else
        {
            NextHandler?.HandleRequest(request);
        }
    }
}