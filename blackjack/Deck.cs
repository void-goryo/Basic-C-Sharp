using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();   //Card is a model being taken from the class "Cards", which houses a face and suit that can hold a value set to it

            //makes two lists of values
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three","Four" ,"Five","Six","Seven","Eight", "Nine", "Ten", "Ace", "Jack", "Queen", "King"
            };

            foreach(string face in Faces)
            {
                foreach(string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }   //this creates the list cards, which allows the top list to be created. This allows us to either set a value, or 
                                                //get a value from another class
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> tempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    tempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = tempList;
            }

        }
    }
}
