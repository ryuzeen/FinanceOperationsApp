using System;

public interface IOperation
{
    string GetDetails();
    decimal GetTotal();
}

public abstract class Operation : IOperation
{
    private static int nextId = 1;

    public int Id { get; }
    public DateTime Date { get; }
    public string AssetCode { get; }
    public int Quantity { get; }
    public decimal Price { get; }

    public Operation(string assetCode, int quantity, decimal price)
    {
        Id = nextId++;
        Date = DateTime.Now;
        AssetCode = assetCode;
        Quantity = quantity;
        Price = price;
    }

    public decimal GetTotal() => Quantity * Price;

    public abstract string GetDetails();
}
