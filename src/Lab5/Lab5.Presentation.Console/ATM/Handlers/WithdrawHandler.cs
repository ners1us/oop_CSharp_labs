using Lab5.Application.Abstractions;
using Lab5.Application.Models;

namespace Lab5.Presentation.Console.ATM.Handlers;

public class WithdrawHandler : AtmOperationHandler
{
    public WithdrawHandler(IAccountRepository accountRepository)
        : base(accountRepository)
    {
    }

    public override void HandleRequest(AtmRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (request.Operation == "Withdraw")
        {
            Account? account = Database.FindAccount(request.AccountNumber);

            if (account is not null && account.Pin == request.Pin && account.Balance >= request.Amount)
            {
                var updatedAccount = new Account(
                    account.Number,
                    account.Pin,
                    account.Balance - request.Amount);

                Database.UpdateAccount(updatedAccount);
                Database.SaveTransaction(request.AccountNumber, "Withdrawal", request.Amount);
                System.Console.WriteLine("Withdrawal successful");
            }
            else
            {
                System.Console.WriteLine("Insufficient funds or invalid PIN");
            }
        }
        else
        {
            NextHandler?.HandleRequest(request);
        }
    }
}