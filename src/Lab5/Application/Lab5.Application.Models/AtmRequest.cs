namespace Lab5.Application.Models;

public class AtmRequest
{
    public int AccountNumber { get; set; }
    public int Pin { get; set; }
    public string? Operation { get; set; }
    public double Amount { get; set; }
    public int NewPin { get; set; }
}