using Lab5.Application.Abstractions;
using Lab5.Application.Models;

namespace Lab5.Presentation.Console.ATM.Handlers;

public class DepositHandler : AtmOperationHandler
{
    public DepositHandler(IAccountRepository accountRepository)
        : base(accountRepository)
    {
    }

    public override void HandleRequest(AtmRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (request.Operation == "Deposit")
        {
            Account? account = Database.FindAccount(request.AccountNumber);

            if (account is not null && account.Pin == request.Pin)
            {
                var updatedAccount = new Account(
                    account.Number,
                    account.Pin,
                    account.Balance - request.Amount);

                Database.UpdateAccount(updatedAccount);
                Database.SaveTransaction(request.AccountNumber, "Deposit", request.Amount);
                System.Console.WriteLine("Deposit successful");
            }

            Database.SaveAccount(account);
        }
        else
        {
            NextHandler?.HandleRequest(request);
        }
    }
}