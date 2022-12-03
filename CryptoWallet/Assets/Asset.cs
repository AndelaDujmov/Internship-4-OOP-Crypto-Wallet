namespace CryptoWallet;

public abstract class Asset
{
    private Guid Address { get; }
    protected string Name { get; set; }
    private decimal Value { get; set; }
    
    public Asset(string name, decimal value)
    {
        Address = Guid.NewGuid();
        Name = name;
        Value = value;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}