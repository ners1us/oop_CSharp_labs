using Lab5.Application.Abstractions;
using Lab5.Application.Models;
using Lab5.Presentation.Console.ATM.Handlers;

namespace Lab5.Presentation.Console.Atm;

public class AutomaticTellerMachine
{
    private readonly AtmOperationHandler _operationHandler;

    public AutomaticTellerMachine(IAccountRepository database)
    {
        var createAccountHandler = new CreateAccountHandler(database);
        var viewBalanceHandler = new ViewBalanceHandler(database);
        var withdrawHandler = new WithdrawHandler(database);
        var depositHandler = new DepositHandler(database);
        var viewHistoryHandler = new ViewHistoryHandler(database);
        var changePasswordHandler = new ChangePinHandler(database);

        createAccountHandler.SetNextHandler(viewBalanceHandler);
        viewBalanceHandler.SetNextHandler(withdrawHandler);
        withdrawHandler.SetNextHandler(depositHandler);
        depositHandler.SetNextHandler(viewHistoryHandler);
        viewHistoryHandler.SetNextHandler(changePasswordHandler);

        _operationHandler = createAccountHandler;
    }

    public void ProcessRequest(AtmRequest request)
    {
        _operationHandler.HandleRequest(request);
    }
}