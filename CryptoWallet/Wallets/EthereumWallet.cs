using CryptoWallet.Interfaces;

namespace CryptoWallet;

public sealed class EthereumWallet:CryptoWallet, IFungibleInteraction, INonFungibleInteraction
{
    public override void Print()
    {
        Console.WriteLine("Type: Ethereum Wallet");
        base.Print();
    }

    public List<Guid> AddressesOfNonFungibleAssets { get; set; }
}