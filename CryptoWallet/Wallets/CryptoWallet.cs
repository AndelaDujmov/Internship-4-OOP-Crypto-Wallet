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
    public virtual void Print()
    {
        Console.WriteLine($"Address: {Address}");
    }

    public void ReturnTotalUSDValue(decimal number)
    {
        decimal total = 0;

        foreach (var address in FungibleAssetBalance)
        {
            total += address.Quantity;
        }

        total *= number;

        Console.WriteLine($"Vrijednost: {total}");
    }

    public void AddValueGuidToWallet(Guid id, int value) 
    {
       FungibleAssetBalance.Add((id, value));
    }
}