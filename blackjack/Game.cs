using System;
using System.Collections.Generic;
using System.Text;

namespace blackjack
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();        //say that you NEED to use this method

        public virtual void ListPlayers()       //a virtual method in an abstract class means that the method gets inhereted in an inhereting class to be overwriten
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
