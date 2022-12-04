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

    public Guid GetId()
    {
        return Address;
    }

    public decimal GetValue()
    {
        return Value;
    }

    public bool FindAssetByID(Guid id)
    {
        if (id.Equals(Address))
            return true;
        return false;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}