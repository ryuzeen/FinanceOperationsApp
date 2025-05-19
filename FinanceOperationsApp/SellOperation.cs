public class SellOperation : Operation
{
    public SellOperation(string assetCode, int quantity, decimal price)
        : base(assetCode, quantity, price) { }

    public override string GetDetails()
    {
        return $"VENDA : [{Id:D3}] {Date:dd/MM/yyyy HH:mm} - {AssetCode} x{Quantity} @ R$ {Price:0.00} = R$ {GetTotal():0.00}";
    }
}
