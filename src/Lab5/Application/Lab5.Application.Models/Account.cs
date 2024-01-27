namespace Lab5.Application.Models;
public class Account
{
    public Account(
        int number,
        int pin,
        double balance)
    {
        ArgumentNullException.ThrowIfNull(number);
        ArgumentNullException.ThrowIfNull(pin);
        ArgumentNullException.ThrowIfNull(balance);

        Number = number;
        Pin = pin;
        Balance = balance;
    }

    public int Number { get; private set; }
    public int Pin { get; private set; }
    public double Balance { get; private set; }
}