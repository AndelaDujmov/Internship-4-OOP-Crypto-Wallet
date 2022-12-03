using CryptoWallet.Interfaces;

namespace CryptoWallet;

public sealed class SolanaWallet:CryptoWallet, IFungibleInteraction, INonFungibleInteraction
{
    public override string ToString()
    {
        return base.ToString();
    }

    public List<Guid> AddressesOfNonFungibleAssets { get; set; }
}