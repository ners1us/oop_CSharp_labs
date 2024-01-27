using Lab5.Application.Abstractions;
using Lab5.Application.Models;

namespace Lab5.Presentation.Console.ATM.Handlers;

public abstract class AtmOperationHandler
{
    protected AtmOperationHandler(IAccountRepository database)
    {
        Database = database;
    }

    public AtmOperationHandler? NextHandler { get; private set; }
    public IAccountRepository Database { get; private set; }

    public void SetNextHandler(AtmOperationHandler? nextHandler)
    {
        NextHandler = nextHandler;
    }

    public abstract void HandleRequest(AtmRequest request);
}