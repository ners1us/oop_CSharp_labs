using Lab5.Application.Abstractions;
using Lab5.Application.Models;

namespace Lab5.Presentation.Console.ATM.Handlers;

public class ViewBalanceHandler : AtmOperationHandler
{
    public ViewBalanceHandler(IAccountRepository accountRepository)
        : base(accountRepository)
    {
    }

    public override void HandleRequest(AtmRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (request.Operation == "ViewBalance")
        {
            Account? account = Database.FindAccount(request.AccountNumber);

            if (account is not null && account.Pin == request.Pin)
            {
                System.Console.WriteLine($"Account balance: {account.Balance}");
            }
            else
            {
                System.Console.WriteLine("Invalid account number or PIN");
            }
        }
        else
        {
            NextHandler?.HandleRequest(request);
        }
    }
}
