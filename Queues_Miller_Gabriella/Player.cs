using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Miller_Gabriella
{
    internal class Player
    {
        // Auto-implemented property to store player's health.
        public int Health { get; set; }

        // Read-only property to store the player's gamer tag.
        public string GamerTag { get; }

        // Constructor to initialize the player's health and gamer tag.
        public Player(int healthParam, string nameParam)
        {
            Health = healthParam;
            GamerTag = nameParam;
        }

        // Method to handle a player joining a game.
        public void JoinGame(Game game, Queue<Player> queue)
        {
            // If the game is full, add the player to the waiting queue.
            if (game.CurrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this);
            }
            else
            {
                // Otherwise, print a message and increment the number of current players.
                Console.WriteLine("Joining Game!");
                game.CurrentPlayers++;
            }
        }

        // Override ToString method to return the player's gamer tag.
        public override string ToString()
        {
            return GamerTag;
        }
    }
}
