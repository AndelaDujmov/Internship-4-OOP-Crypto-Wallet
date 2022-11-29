namespace CryptoWallet;

public class FungibleAsset
{
    public Guid Address { get; }
    public string Name { get; set; } //need to be unique
    public string Label { get; set; }
    
    public Double Value { get; private set; }

    public FungibleAsset(string name, string label)
    {
        Address = Guid.NewGuid();
        Name = name;
        Label = label;
    }
}