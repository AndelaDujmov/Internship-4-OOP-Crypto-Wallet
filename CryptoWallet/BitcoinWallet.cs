namespace CryptoWallet;

public class BitcoinWallet
{
    public Guid Address { get; }

    public BitcoinWallet()
    {
        Address = Guid.NewGuid();
    }
}