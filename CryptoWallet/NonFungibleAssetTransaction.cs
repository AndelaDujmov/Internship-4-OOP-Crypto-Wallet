namespace CryptoWallet;

public class NonFungibleAssetTransaction
{
    public Guid Address { get; }
    public string FungibleAssetAddress { get; private set; }
    public DateTime Date { get; private set; }
    public double InitialBalanceSent { get; set; }
    public double FinalBalanceSent { get; set; }
    public double InitialBalanceRecieved { get; set; }
    public double FinalBalanceRecieved { get; set; }
    
    
    public NonFungibleAssetTransaction(string fungibleAssetAddress, DateTime date)
    {
        Address = Guid.NewGuid();
        FungibleAssetAddress = fungibleAssetAddress;
        Date = date;
    }
}