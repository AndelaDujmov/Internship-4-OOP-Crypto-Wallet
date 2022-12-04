using CryptoWallet.Interfaces;

namespace CryptoWallet;

public sealed class SolanaWallet:CryptoWallet, IFungibleInteraction, INonFungibleInteraction
{
    public override void Print()
    {
        Console.WriteLine("Type: Solana Wallet");
        base.Print();
    }

    public List<Guid> AddressesOfNonFungibleAssets { get; set; }
}