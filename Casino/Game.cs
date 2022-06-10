using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }      //creates en empty list. You NEED to insantiate a list to use them

        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

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
