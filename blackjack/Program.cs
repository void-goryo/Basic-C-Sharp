using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3);   //named parameter
            

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);

            Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);

            Console.WriteLine("Times shuffled {0}", timesShuffled);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, out int timesShuffeled, int times = 1)
        {
            timesShuffeled = 0;
            for(int i = 0; i < times; i++)
            {
                timesShuffeled++;
                List<Card> tempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    tempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = tempList;
            }
            
            return deck;
        }

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
