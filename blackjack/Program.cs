﻿using System;
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
            


            Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            Console.ReadLine();
        }
    }
}
