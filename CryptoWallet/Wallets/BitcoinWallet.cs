using System.Transactions;
using CryptoWallet.Interfaces;

namespace CryptoWallet;

public sealed class BitcoinWallet:CryptoWallet, IFungibleInteraction
{

   

    private void GetChangeValueOfAsset(List<Asset> assets, List<Transaction> transactions)
    {
        //po transakcijama onda gledamo po najzadnjim datumima
        /*
         if (previousValues > currentValues)
        {
            percentage = (previousValues % currentValues) * 100;
            return $"Total value of the wallet has dropped by {percentage}!\n";
        }
        percentage = (currentValues % previousValues) * 100;
        return $"Total value of the wallet has increased by {percentage}!\n";
         */
    }
    
    
    
    public override void Print(List<Asset> assets, List<Transaction> transactions)
    {
        Console.WriteLine("Wallet type: Bitcoin Wallet");
        
        if(FungibleAssetBalance.Count is 0)
            Console.WriteLine("Your wallet does not have any assets!");
        else
        {
            Console.WriteLine("Asset Address    -     Quantity");
            foreach (var balance in FungibleAssetBalance)
            {
                Console.WriteLine($"{balance.Address}  -  {balance.Quantity}  -  ");
            }
        }

        Console.WriteLine($"Total balance {TotalFungibleAssets(assets)}");
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