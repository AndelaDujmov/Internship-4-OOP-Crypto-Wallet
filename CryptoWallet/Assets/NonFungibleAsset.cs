namespace CryptoWallet;

public class NonFungibleAsset
{
    public Guid Address { get; }
    public string Name { get; set; }
    public Decimal Value { get; set; }

    public NonFungibleAsset(string name, Decimal value)
    {
        Address = Guid.NewGuid();
        Name = name;
        Value = value;
    }
}