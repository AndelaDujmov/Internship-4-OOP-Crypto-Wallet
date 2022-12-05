using System.Transactions;
using CryptoWallet.Interfaces;

namespace CryptoWallet;

public sealed class SolanaWallet:CryptoWallet, IFungibleInteraction, INonFungibleInteraction
{
    public List<Guid> AddressesOfNonFungibleAssets { get; set; } = new List<Guid>();
    
    public override void Print(List<Asset> assets, List<Transaction> transactions)
    {
        Console.WriteLine("Wallet type: Ethereum Wallet");
        
        
        Console.WriteLine("Non fungible assets:");
        foreach (var address in AddressesOfNonFungibleAssets)
        {
            Console.WriteLine(address);
        }
        if(FungibleAssetBalance.Count is 0)
            Console.WriteLine("Your wallet does not have any assets!");
        else
        {
            Console.WriteLine("Asset Address     -     Quantity");
            foreach (var balance in FungibleAssetBalance)
            {
                Console.WriteLine($"{balance.Address}  -  {balance.Quantity} ");
            }
        }


        var total = TotalFungibleAssets(assets);
        Console.WriteLine($"Total: {total}");
        Console.WriteLine("Supported assets:");
        AddressesOfSupportedAssets.ForEach(address => Console.WriteLine(address));
        
        if(AddressesAssetTransactions.Count is 0)
            Console.WriteLine("You did not have any transactions listed!");
        else
        {
            Console.WriteLine("List of your transactions:");
            AddressesAssetTransactions.ForEach(transaction => Console.WriteLine(transaction));
        }
    }

  
}