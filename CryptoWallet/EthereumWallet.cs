namespace CryptoWallet;

public class EthereumWallet
{
    public Guid Address { get; }

    public EthereumWallet()
    {
        Address = Guid.NewGuid();
    }
}