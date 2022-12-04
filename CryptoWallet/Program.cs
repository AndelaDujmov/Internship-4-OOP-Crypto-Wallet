using CryptoWallet;

namespace CryptoWallet;

class Program
{
    static void Main(string[] args)
    {
        string? choice;
        Console.WriteLine("Welcome to the Crypto Wallet App, your personal crypto accountant!");
        Console.WriteLine("Don't have a personal wallet? Create one today! (y/n)");
        choice = Console.ReadLine();
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
                    break;
            }
        }
        Console.WriteLine("Do you already have a wallet? (y/n)");
        choice = Console.ReadLine();
        if (choice is "y")
        {
            CryptoWallet bitcoinWallet = new BitcoinWallet();
            bitcoinWallet.Print();
        }
        Console.WriteLine("Sign out? (y/n)");
        choice = Console.ReadLine();

      
    }
}

