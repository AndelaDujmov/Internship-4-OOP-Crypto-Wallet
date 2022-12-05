using System.Transactions;
using CryptoWallet;
using CryptoWallet.Interfaces;

namespace CryptoWallet;


class Program
{
    static List<Asset> FungibleAssetList = new List<Asset>()
    {
        new FungibleAsset("BTCBitcoin", "BTC", 2.00m),
        new FungibleAsset("ETHEthereum", "ETH", 2.06m),
        new FungibleAsset("USDTTether", "USDT", 1.86m),
        new FungibleAsset("BNBBNB", "BNB", 2.66m),
        new FungibleAsset("Cardano", "ADA", 0.26m),
        new FungibleAsset("Polygon", "MATIC", 5.35m),
        new FungibleAsset("Dai", "DAI", 2.11m),
        new FungibleAsset("Litecoin", "LTC", 1.56m),
        new FungibleAsset("Solana", "SOL", 0.55m),
        new FungibleAsset("Algorand", "ALGO", 3.58m)
    };

    private static List<Transaction> TransactionsList = new List<Transaction>();

    static List<Asset> NonFungableAssetList = new List<Asset>()
    {
        new NonFungibleAsset("Clock", 0.23m, FungibleAssetList[1].GetId()),
        new NonFungibleAsset("HUMAN ONE", 0.43m, FungibleAssetList[2].GetId()),
        new NonFungibleAsset("Stay Free", 0.45m, FungibleAssetList[1].GetId()),
        new NonFungibleAsset("REPLICATOR", 0.49m, FungibleAssetList[3].GetId()),
        new NonFungibleAsset("Metarift", 0.39m, FungibleAssetList[2].GetId()),
        new NonFungibleAsset("Betarift", 2.59m, FungibleAssetList[2].GetId()),
        new NonFungibleAsset("Metarift", 0.49m, FungibleAssetList[2].GetId()),
        new NonFungibleAsset("EtherRock #73", 4.31m, FungibleAssetList[4].GetId()),
        new NonFungibleAsset("EtherRock #27", 1.33m, FungibleAssetList[4].GetId()),
        new NonFungibleAsset("Fidenza #313", 1.55m, FungibleAssetList[2].GetId()),
        new NonFungibleAsset("PEPENOPOULOS, 2016", 4.25m, FungibleAssetList[2].GetId()),
        new NonFungibleAsset("CryptoPunk #2338", 2.22m, FungibleAssetList[2].GetId()),
        new NonFungibleAsset("Doge", 3.11m, FungibleAssetList[5].GetId()),
        new NonFungibleAsset("Save Thousands of Lives", 2.99m, FungibleAssetList[8].GetId()),
        new NonFungibleAsset("A slight lack of symmetry can cause so much pain", 1.56m, FungibleAssetList[8].GetId()),
        new NonFungibleAsset("SMB #1355", 2.26m, FungibleAssetList[8].GetId()),
        new NonFungibleAsset("Save Lives", 2.29m, FungibleAssetList[8].GetId()),
        new NonFungibleAsset("OCEAN FRONT", 1.49m, FungibleAssetList[8].GetId()),
        new NonFungibleAsset("Safe Drift", 5.36m, FungibleAssetList[8].GetId()),
        new NonFungibleAsset("Ocean Dives", 0.52m, FungibleAssetList[8].GetId())
    };

    static List<CryptoWallet> WalletList = new List<CryptoWallet>()
    {
        new BitcoinWallet(),
        new BitcoinWallet(),
        new BitcoinWallet(),
        new EthereumWallet(),
        new EthereumWallet(),
        new EthereumWallet(),
        new SolanaWallet(),
        new SolanaWallet(),
        new SolanaWallet()
    };


    public static void AssignValuesToEachWallet()
    {
        WalletList[0].AddressesOfSupportedAssets.Add(FungibleAssetList[0].GetId());
        WalletList[0].AddressesOfSupportedAssets.Add(FungibleAssetList[3].GetId());
        WalletList[0].AddressesOfSupportedAssets.Add(FungibleAssetList[5].GetId());
        WalletList[0].FungibleAssetBalance.Add((FungibleAssetList[0].GetId(), 4));
        WalletList[0].FungibleAssetBalance.Add((FungibleAssetList[3].GetId(), 10));
        WalletList[0].FungibleAssetBalance.Add((FungibleAssetList[5].GetId(), 14));
        
        WalletList[1].AddressesOfSupportedAssets.Add(FungibleAssetList[1].GetId());
        WalletList[1].AddressesOfSupportedAssets.Add(FungibleAssetList[2].GetId());
        WalletList[1].AddressesOfSupportedAssets.Add(FungibleAssetList[4].GetId());
        WalletList[1].FungibleAssetBalance.Add((FungibleAssetList[1].GetId(), 7));
        WalletList[1].FungibleAssetBalance.Add((FungibleAssetList[2].GetId(), 12));
        WalletList[1].FungibleAssetBalance.Add((FungibleAssetList[4].GetId(), 4));
        
        WalletList[2].AddressesOfSupportedAssets.Add(FungibleAssetList[4].GetId());
        WalletList[2].AddressesOfSupportedAssets.Add(FungibleAssetList[2].GetId());
        WalletList[2].AddressesOfSupportedAssets.Add(FungibleAssetList[9].GetId());
        WalletList[2].FungibleAssetBalance.Add((FungibleAssetList[4].GetId(), 18));
        WalletList[2].FungibleAssetBalance.Add((FungibleAssetList[2].GetId(), 19));
        WalletList[2].FungibleAssetBalance.Add((FungibleAssetList[9].GetId(), 3));

        var nonFungible = WalletList[3] as EthereumWallet;
        nonFungible.AddressesOfSupportedAssets.Add(NonFungableAssetList[1].GetId());
        nonFungible.AddressesOfSupportedAssets.Add(NonFungableAssetList[2].GetId());
        nonFungible.AddressesOfSupportedAssets.Add(NonFungableAssetList[3].GetId());
        nonFungible.AddressesOfSupportedAssets.Add(FungibleAssetList[4].GetId());
        nonFungible.AddressesOfSupportedAssets.Add(FungibleAssetList[5].GetId());
        nonFungible.AddressesOfNonFungibleAssets.Add(NonFungableAssetList[2].GetId());
        nonFungible.AddressesOfNonFungibleAssets.Add(NonFungableAssetList[3].GetId());
        nonFungible.FungibleAssetBalance.Add((FungibleAssetList[4].GetId(), 12));
        nonFungible.FungibleAssetBalance.Add((FungibleAssetList[5].GetId(), 24));
        WalletList[3] = nonFungible;

        nonFungible = WalletList[4] as EthereumWallet;
        nonFungible.AddressesOfNonFungibleAssets.Add(NonFungableAssetList[1].GetId());
        nonFungible.AddressesOfNonFungibleAssets.Add(NonFungableAssetList[6].GetId());
        nonFungible.AddressesOfNonFungibleAssets.Add(NonFungableAssetList[12].GetId());
        nonFungible.AddressesOfSupportedAssets.Add(NonFungableAssetList[1].GetId());
        nonFungible.AddressesOfSupportedAssets.Add(NonFungableAssetList[6].GetId());
        nonFungible.AddressesOfSupportedAssets.Add(NonFungableAssetList[12].GetId());
        nonFungible.AddressesOfSupportedAssets.Add(FungibleAssetList[8].GetId());
        nonFungible.AddressesOfSupportedAssets.Add(FungibleAssetList[2].GetId());
        nonFungible.FungibleAssetBalance.Add((FungibleAssetList[8].GetId(), 22));
        nonFungible.FungibleAssetBalance.Add((FungibleAssetList[2].GetId(), 14));
        WalletList[4] = nonFungible;

        nonFungible = WalletList[5] as EthereumWallet;
        nonFungible.AddressesOfNonFungibleAssets.Add(NonFungableAssetList[10].GetId());
        nonFungible.AddressesOfNonFungibleAssets.Add(NonFungableAssetList[3].GetId());
        nonFungible.AddressesOfSupportedAssets.Add(NonFungableAssetList[10].GetId());
        nonFungible.AddressesOfSupportedAssets.Add(NonFungableAssetList[3].GetId());
        nonFungible.AddressesOfSupportedAssets.Add(FungibleAssetList[8].GetId()); 
        nonFungible.AddressesOfSupportedAssets.Add(FungibleAssetList[1].GetId());
        nonFungible.AddressesOfSupportedAssets.Add(FungibleAssetList[3].GetId());
        nonFungible.FungibleAssetBalance.Add((FungibleAssetList[8].GetId(), 4));
        nonFungible.FungibleAssetBalance.Add((FungibleAssetList[1].GetId(), 13));
        nonFungible.FungibleAssetBalance.Add((FungibleAssetList[3].GetId(), 24));
        WalletList[5] = nonFungible;
        
        var nonFungableSolana = WalletList[6] as SolanaWallet;
        nonFungableSolana.AddressesOfNonFungibleAssets.Add(NonFungableAssetList[13].GetId());
        nonFungableSolana.AddressesOfNonFungibleAssets.Add(NonFungableAssetList[5].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(NonFungableAssetList[13].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(NonFungableAssetList[5].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(FungibleAssetList[2].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(FungibleAssetList[4].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(FungibleAssetList[7].GetId());
        nonFungableSolana.FungibleAssetBalance.Add((FungibleAssetList[2].GetId(), 15));
        nonFungableSolana.FungibleAssetBalance.Add((FungibleAssetList[4].GetId(), 11));
        nonFungableSolana.FungibleAssetBalance.Add((FungibleAssetList[7].GetId(), 4));
        WalletList[6] = nonFungableSolana;
        
        nonFungableSolana = WalletList[7] as SolanaWallet;
        nonFungableSolana.AddressesOfNonFungibleAssets.Add(NonFungableAssetList[11].GetId());
        nonFungableSolana.AddressesOfNonFungibleAssets.Add(NonFungableAssetList[8].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(NonFungableAssetList[11].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(NonFungableAssetList[8].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(FungibleAssetList[1].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(FungibleAssetList[4].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(FungibleAssetList[6].GetId());
        nonFungableSolana.FungibleAssetBalance.Add((FungibleAssetList[1].GetId(), 30));
        nonFungableSolana.FungibleAssetBalance.Add((FungibleAssetList[4].GetId(), 12));
        nonFungableSolana.FungibleAssetBalance.Add((FungibleAssetList[6].GetId(), 3));
        WalletList[7] = nonFungableSolana;
        
        nonFungableSolana = WalletList[8] as SolanaWallet;
        nonFungableSolana.AddressesOfNonFungibleAssets.Add(NonFungableAssetList[10].GetId());
        nonFungableSolana.AddressesOfNonFungibleAssets.Add(NonFungableAssetList[8].GetId());
        nonFungableSolana.AddressesOfNonFungibleAssets.Add(NonFungableAssetList[3].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(NonFungableAssetList[10].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(NonFungableAssetList[8].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(NonFungableAssetList[3].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(FungibleAssetList[4].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(FungibleAssetList[2].GetId());
        nonFungableSolana.AddressesOfSupportedAssets.Add(FungibleAssetList[1].GetId());
        nonFungableSolana.FungibleAssetBalance.Add((FungibleAssetList[4].GetId(), 10));
        nonFungableSolana.FungibleAssetBalance.Add((FungibleAssetList[2].GetId(), 22));
        nonFungableSolana.FungibleAssetBalance.Add((FungibleAssetList[1].GetId(), 11));
        WalletList[8] = nonFungableSolana;
    }

    public static void CreateNewAsset()
    {
        char.TryParse(Console.ReadLine(), out char choice);
        if (choice is 'y')
        {
            Console.Clear();
            Console.WriteLine("You have selected the option Create New Wallet!");
            Console.WriteLine("Please enter the wallet type you want to create in order");
            Console.WriteLine("a - Bitcoin Wallet");
            Console.WriteLine("b - Solana Wallet");
            Console.WriteLine("c - Ethereum Wallet");
            
            char.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 'a':
                    Console.WriteLine("You have selected the option Create bitcoin wallet!");
                    CryptoWallet bitcoinWallet = new BitcoinWallet();
                    WalletList.Add(bitcoinWallet);
                    break;
                case 'b':
                    Console.WriteLine("You have selected the option Create solana wallet!");
                    CryptoWallet solanaWallet = new SolanaWallet();
                    WalletList.Add(solanaWallet);
                    break;
                case 'c':
                    Console.WriteLine("You have selected the option Create ethereum wallet!");
                    CryptoWallet ethereumWallet = new EthereumWallet();
                    WalletList.Add(ethereumWallet);
                    break;
                default:
                    Console.WriteLine("You havent chose anything yet! Please try again!");
                    Thread.Sleep(1500);
                    MainMenu();
                    break;
            }
        }
    }

    public static void SubMenu(string address)
    {
        Console.WriteLine($"Your wallet: {address}\n" +
                          $"Choose one of the above:\n" +
                          $"1 - Portfolio\n" +
                          $"2 - Transfer\n" +
                          $"3 - Transaction History\n" +
                          $"0 - Back to Main Menu\n");

        var input = Console.Read();

        switch (input)
        {
            case 0:
                Console.WriteLine("You decided to go back to the main menu.");
                Thread.Sleep(1000);
                MainMenu();
                break;
            case 1:
                Console.WriteLine("You decided to check wallet's portfolio.");
                break;
            case 2:
                Console.WriteLine("You decided to do transfers!");
                break;
            case 3:
                Console.WriteLine("You decided to check you transaction history.");
                break;
        }
        
        }

    public static void ListElementsInWallet()
    {
        char.TryParse(Console.ReadLine(), out char choice);
        if (choice is 'y')
        {
            WalletList.ForEach(wallet => wallet.Print(FungibleAssetList, TransactionsList));
            Console.WriteLine("Write the address of a wallet you would like to use");
            var addressWallet = Console.ReadLine(); 
            SubMenu(addressWallet);
        }
    }
    
    public static void MainMenu()
    {
        AssignValuesToEachWallet();
        
        while (true)
        {
            Console.Clear();   
            Console.WriteLine("Welcome to the Crypto Wallet App, your personal crypto accountant!");
            Console.WriteLine("Don't have a personal wallet? Create one today! (y/n)");
            CreateNewAsset();
            Console.WriteLine("Do you already have a wallet? (y/n)");
            ListElementsInWallet();
            Console.WriteLine("Sign out? (y/n)");
            char.TryParse(Console.ReadLine(), out char choice);
            if(choice != 'y')
                continue;
            else
            {
                Console.WriteLine("Logging out...");
                Thread.Sleep(1000);
                break;
            }
        }
    }
    
    static void Main(string[] args)
    {
        MainMenu();
    }
}

