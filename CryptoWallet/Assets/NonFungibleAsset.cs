namespace CryptoWallet;

public class NonFungibleAsset:Asset
{
    protected Guid FungibleAssetAddress { get; }
    
    public NonFungibleAsset(string name, decimal value, Guid fungibleAssetAddress):base(name, value)
    {
        FungibleAssetAddress = fungibleAssetAddress;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}