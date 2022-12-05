using System.Transactions;

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

    public abstract void Print(List<Asset> assets, List<Transaction> transactions);
   
    
    public void AddValueGuidToWallet(Guid id, int value) 
    {
       FungibleAssetBalance.Add((id, value)); // triba unos i provjera je li se wallet nalazi unutar ovog asseta
    }
    
    private bool FindValue(Guid address)
    {
        foreach (var balance in FungibleAssetBalance)
        {
            if (balance.Address.Equals(address))
                return true;
        }

        return false;
    }
    public decimal TotalFungibleAssets(List<Asset> assets)
    {
        decimal totalAsset = 0m;

        foreach (var asset in assets)
        {
            if (FindValue(asset.GetId()))
                totalAsset += asset.GetValue();
        }

        return totalAsset;
    }
}