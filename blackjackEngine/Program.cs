using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace blackjackEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.InitDeck();
        }
        class Deck
        {
            Random rng = new Random();
            List<string> deck = new List<string>();
            public void InitDeck()
            {
                string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
                string[] suits = { "♠", "♥", "♦", "♣" };
                
                deck = new List<string>();

                foreach (string rank in ranks)
                {
                    foreach (string suit in suits)
                    {
                        deck.Add($"{rank}{suit}");
                    }
                }

                deck = deck.OrderBy(x => rng.Next()).ToList();
                for (int i = 0; i < deck.Count; i++) 
                {
                    Console.WriteLine(deck[i]);
                }
                Console.WriteLine(deck.Count);
            }



        }
    }
}
