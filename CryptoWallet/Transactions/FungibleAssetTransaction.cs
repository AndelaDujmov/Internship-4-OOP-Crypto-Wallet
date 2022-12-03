namespace CryptoWallet;

public class FungibleAssetTransaction:AssetTransaction
{
    public Decimal InitialBalanceSent { get; set; }
    public Decimal FinalBalanceSent { get; set; }
    public Decimal InitialBalanceRecieved { get; set; }
    public Decimal FinalBalanceRecieved { get; set; }
    public override string ToString()
    {
        return base.ToString();
    }

    public FungibleAssetTransaction(string address, DateTime time, Guid recieverAddress, Guid senderAddress) : base(address, time, recieverAddress, senderAddress)
    {
        
    }
}