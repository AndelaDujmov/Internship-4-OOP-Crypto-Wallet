using CryptoWallet.Interfaces;

namespace CryptoWallet;

public sealed class BitcoinWallet:CryptoWallet, IFungibleInteraction
{
    public override void Print()
    {
        Console.WriteLine("Type: Bitcoin Wallet");
        base.Print();
    }
}