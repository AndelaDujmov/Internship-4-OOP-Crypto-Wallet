namespace CryptoWallet;

public class FungibleAsset:Asset
{
    public string Label { get; set; }
    public decimal totalValueUSD { get; set; }

    public FungibleAsset(string name, string label, decimal value) : base(name, value)
    {
        Name = name;
        Label = label;
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public bool IsUnique(string name)
    {
        if (Name.Equals(name))
            return false;
        return true;
    }
}