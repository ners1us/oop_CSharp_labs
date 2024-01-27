using System.Collections.ObjectModel;
using Lab5.Application.Abstractions;
using Lab5.Application.Models;

namespace Lab5.Presentation.Console.ATM.Handlers;

public class ViewHistoryHandler : AtmOperationHandler
{
    public ViewHistoryHandler(IAccountRepository accountRepository)
        : base(accountRepository)
    {
    }

    public override void HandleRequest(AtmRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (request.Operation == "ViewHistory")
        {
            Account? account = Database.FindAccount(request.AccountNumber);

            if (account != null && account.Pin == request.Pin)
            {
                ReadOnlyCollection<string> history = Database.GetTransactionHistory(request.AccountNumber);

                if (history.Count == 0)
                {
                    System.Console.WriteLine("No transaction history");
                }
                else
                {
                    System.Console.WriteLine("Transaction history:");
                    foreach (string operation in history)
                    {
                        System.Console.WriteLine(operation);
                    }
                }
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