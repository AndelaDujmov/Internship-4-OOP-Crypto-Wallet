namespace CryptoWallet;

public class CryptoWallet
{
    public Guid Address { get; }
    public (Guid Address, int Quantity) FungibleAssetAddresAndQuantity;

    public CryptoWallet()
    {
        Address = Guid.NewGuid();
    }
}