namespace CryptoWallet;

public class FungibleAsset:Asset
{
    public string Label { get; set; }

    public FungibleAsset(string name, string label, decimal value) : base(name, value)
    {
        Name = name;
        Label = label;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}