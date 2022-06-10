using System;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            ////This will not be used here      This will create a text if it is not there.
            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\gabe\Desktop\log.txt", text);  //@ reads the line as a litteral text

            //string text = File.ReadAllText(@"C:\Users\gabe\Desktop\log.txt");

            const string casinoName = "Grand Hostel and Casino";        //will never change once the program is run


            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to play a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if(answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();         //Global Unique Identifier
                using (StreamWriter file = new StreamWriter(@"C:\Users\Gabe\desktop\basic-c-sharp\logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();

        
        }
    }
}
