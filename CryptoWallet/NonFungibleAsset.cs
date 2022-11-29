namespace CryptoWallet;

public class NonFungibleAsset
{
    public Guid Address { get; }
    public string Name { get; set; }
    public double Value { get; set; }

    public NonFungibleAsset(string name, double value)
    {
        Address = Guid.NewGuid();
        Name = name;
        Value = value;
    }
}