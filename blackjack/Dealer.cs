using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace blackjack
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand) 
        {
            Hand.Add(Deck.Cards.First());
            //This will add the cards being delt to the string
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            //This will log the added card
            using (StreamWriter file = new StreamWriter(@"C:\Users\Gabe\desktop\basic-c-sharp\logs\log.txt", true))
            {
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);
        }
    }
}
