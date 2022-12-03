namespace CryptoWallet;

public class NonFungibleAssetTransaction:AssetTransaction
{
    
    
    
    
    public NonFungibleAssetTransaction(string fungibleAssetAddress, DateTime date, Guid recieverAddress, Guid senderAddress) : base(fungibleAssetAddress, date, recieverAddress, senderAddress)
    {
    }

    public override string ToString()
    {
        return base.ToString();
    }
}