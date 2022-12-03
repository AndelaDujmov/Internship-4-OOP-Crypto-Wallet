using CryptoWallet.Interfaces;

namespace CryptoWallet;

public sealed class BitcoinWallet:CryptoWallet, IFungibleInteraction
{
    public override string ToString()
    {
        return base.ToString();
    }
}