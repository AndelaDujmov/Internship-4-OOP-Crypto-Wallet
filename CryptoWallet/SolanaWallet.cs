namespace CryptoWallet;

public class SolanaWallet
{
 
    public Guid Address { get; }

    public SolanaWallet()
    {
        Address = Guid.NewGuid();
    }
}