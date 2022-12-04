using CryptoWallet;

namespace CryptoWallet;


class Program
{

    public static void CreateNewAsset()
    {
        var choice = Console.ReadLine();
        if (choice is "y")
        {
            Console.Clear();
            Console.WriteLine("You have selected the option Create New Wallet!");
            Console.WriteLine("Please enter the wallet type you want to create in order");
            Console.WriteLine("a - Bitcoin Wallet");
            Console.WriteLine("b - Solana Wallet");
            Console.WriteLine("c - Ethereum Wallet");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    Console.WriteLine("You have selected the option Create bitcoin wallet!");
                    CryptoWallet bitcoinWallet = new BitcoinWallet();
                    break;
                case "b":
                    Console.WriteLine("You have selected the option Create solana wallet!");
                    CryptoWallet solanaWallet = new SolanaWallet();
                    break;
                case "c":
                    Console.WriteLine("You have selected the option Create ethereum wallet!");
                    CryptoWallet ethereumWallet = new EthereumWallet();
                    break;
                default:
                    Console.WriteLine("You havent chose anything yet! Please try again!");
                    MainMenu();
                    break;
            }
        }
    }

    public static void ListElementsInWallet()
    {
        var choice = Console.ReadLine();
        if (choice is "y")
        {
           //list all elements in each value
        }
    }

    public static void Quit()
    {
        var choice = Console.ReadLine();
        if(choice is "n")
            MainMenu();
        else
        {
            Console.WriteLine("Logging out...");
            return;
        }
    }
    
    public static void MainMenu()
    {
        
        Console.Clear();
        Asset asset1 = new FungibleAsset("BTCBitcoin", "BTC", 2.00m);
        Asset asset2 = new FungibleAsset("ETHEthereum", "ETH", 2.06m);
        Asset asset3 = new FungibleAsset("USDTTether", "USDT", 2.06m);
        Asset asset4 = new FungibleAsset("BNBBNB", "BNB", 2.06m);
        Asset asset5 = new FungibleAsset("Cardano", "ADA", 2.06m);
        Asset asset6 = new FungibleAsset("Polygon", "MATIC", 2.06m);
        Asset asset7 = new FungibleAsset("Dai", "DAI", 2.06m);
        Asset asset8 = new FungibleAsset("Litecoin", "LTC", 2.06m);
        Asset asset9 = new FungibleAsset("Solana", "SOL", 2.06m); 
        Asset asset10 = new FungibleAsset("Algorand", "ALGO", 2.06m);
        
        string? choice;
        Console.WriteLine("Welcome to the Crypto Wallet App, your personal crypto accountant!");
        Console.WriteLine("Don't have a personal wallet? Create one today! (y/n)");
        CreateNewAsset();
        Console.WriteLine("Do you already have a wallet? (y/n)");
        ListElementsInWallet();
        Console.WriteLine("Sign out? (y/n)");
        Quit();
    }
    
    static void Main(string[] args)
    {
        MainMenu();
    }
}

