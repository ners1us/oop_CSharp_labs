using Lab5.Application.Abstractions;
using Lab5.Application.Models;

namespace Lab5.Presentation.Console.ATM.Handlers;

public class ChangePinHandler : AtmOperationHandler
{
    public ChangePinHandler(IAccountRepository accountRepository)
        : base(accountRepository)
    {
    }

    public override void HandleRequest(AtmRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (request.Operation == "ChangePIN")
        {
            int accountNumber = request.AccountNumber;
            int newPin = request.NewPin;

            Account? existingAccount = Database.FindAccount(accountNumber);
            if (existingAccount is not null)
            {
                Database.ChangePin(accountNumber, newPin);
                System.Console.WriteLine("Pin changed successfully");
            }
            else
            {
                System.Console.WriteLine("Account not found");
            }
        }
        else
        {
            NextHandler?.HandleRequest(request);
        }
    }
}