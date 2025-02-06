using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Miller_Gabriella
{
    internal class Game
    {
        // Read-only property representing the maximum number of players allowed in the game.
        public int MaxPlayers { get; }

        // Property to track the current number of players in the game.
        public int CurrentPlayers { get; set; }

        // Constructor to initialize the game's maximum player limit and current player count.
        public Game(int maxP, int currentP)
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }

        // Method to remove a player from the game.
        // Ensures that CurrentPlayers does not go below zero.
        public void KickPlayer()
        {
            if (CurrentPlayers > 0)
            {
                CurrentPlayers--;
            }
            else
            {
                Console.WriteLine("No players to kick!");
            }
        }

        // Method to check if there are available slots in the game and add a player from the queue if possible.
        public void CheckQueue(Queue<Player> playerQueue)
        {
            // If there is room for more players, attempt to add one from the queue.
            if (CurrentPlayers < MaxPlayers)
            {
                // If the queue is not empty, dequeue a player and increase the player count.
                if (playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else
                {
                    // If no players are in the queue, notify the console.
                    Console.WriteLine("No players in queue!");
                }
            }
        }
    }
}
