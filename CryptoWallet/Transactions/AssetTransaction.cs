namespace CryptoWallet;

public abstract class AssetTransaction
{
    private Guid ID { get; }
    protected string AddressOfAsset { get; }
    public DateTime Date { get; }
    public Guid WalletSenderAddress { get; }
    public Guid WalletRecieverAddress { get; }
    public bool IsRevoked { get; set; }

    protected AssetTransaction(string address, DateTime dateTime, Guid walletRecieverAddress, Guid walletSenderAddress)
    {
        ID = Guid.NewGuid();
        AddressOfAsset = address;
        Date = dateTime;
        WalletRecieverAddress = walletRecieverAddress;
        walletSenderAddress = walletSenderAddress;
    }

    
    public override string ToString()
        {
            return $"Transaction {ID} on date {Date} by {WalletSenderAddress} to {WalletRecieverAddress}, {IsRevoked}";
        }
}