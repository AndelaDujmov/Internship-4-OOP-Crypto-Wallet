namespace CryptoWallet;

public class NonFungibleAssetTransaction
{
    public Guid Address { get; }
    public string FungibleAssetAddress { get; private set; }
    public DateTime Date { get; private set; }
    public Decimal InitialBalanceSent { get; set; }
    public Decimal FinalBalanceSent { get; set; }
    public Decimal InitialBalanceRecieved { get; set; }
    public Decimal FinalBalanceRecieved { get; set; }
    
    
    public NonFungibleAssetTransaction(string fungibleAssetAddress, DateTime date)
    {
        Address = Guid.NewGuid();
        FungibleAssetAddress = fungibleAssetAddress;
        Date = date;
    }
}