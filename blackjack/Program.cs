using System;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

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

            const string casinoName = "Grand Hotel and Casino";        //will never change once the program is run


            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                //tries to convert to int. if it works, it'll send the value to bank and stop the while loop.
                if (!validAnswer)
                {
                    Console.WriteLine("Please enter digits only, no deciamls. ");
                }
                //this happens if it could not convert the string to an int
            }


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
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)       //you should always have your specific exceptions first, and then your general exceptions
                    {
                        Console.WriteLine("The game has suspected you of fraud. An associate will be with you shortly.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }

                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();

        
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;
                                        Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES" +
                                    @"(@ExceptionType, @ExceptionMessage, @TimeStamp)";     //peramiterized query... look it up if you don't remember
            using (SqlConnection connection = new SqlConnection(connectionString))      //managing memory and closing it up to free more memory
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);        //protects against sql injection
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;
                                        Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"Select ID, ExceptionType, ExceptionMessage, TimeStamp from Exceptions";      //selects the table and values from the table that we are going to use

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using(SqlConnection connection = new SqlConnection(connectionString))       //sets up a new sql connection using the connection string
            {
                SqlCommand command = new SqlCommand(queryString, connection);           //takes the query and and connection and adds it to a sql command

                connection.Open();                  //opens sql connection

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}
