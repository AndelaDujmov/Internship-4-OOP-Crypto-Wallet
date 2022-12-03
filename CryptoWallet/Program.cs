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
        Console.WriteLine("Do you already have a wallet? (y/n)");
        choice = Console.ReadLine();
        Console.WriteLine("Sign out? (y/n)");
        choice = Console.ReadLine();

        CryptoWallet wallet = new BitcoinWallet();
        CryptoWallet wallet2 = new SolanaWallet();
        CryptoWallet wallet3 = new SolanaWallet();// kreiranje walleta (ABSTRAKCIJA)
        
    }
}

