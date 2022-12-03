namespace CryptoWallet;

public abstract class CryptoWallet
{
    public Guid Address { get;  }

    public List<(Guid Address, int Quantity)> FungibleAssetBalance { get; } = new List<(Guid Address, int Quantity)>();
    public List<Guid> AddressesOfSupportedAssets { get; set;  } = new List<Guid>();
    public List<Guid> AddressesAssetTransactions { get; } = new List<Guid>();

    public CryptoWallet()
    {
        Address = Guid.NewGuid();
    }
    public override string ToString()
    {
        return base.ToString();
    }
}