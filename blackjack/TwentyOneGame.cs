using System;
using System.Collections.Generic;
using System.Text;

namespace blackjack
{
    public class TwentyOneGame : Game   //this inherits properties from the Game class
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("Blackjack Players: ");
            base.ListPlayers();                         //uses what is already writen in ListPlayers()
        }
    }
}
