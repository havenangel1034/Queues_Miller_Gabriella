namespace Queues_Miller_Gabriella
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating a game instance with a maximum of 50 players and 49 currently in the game.
            Game myGame = new Game(50, 49);

            // Creating a queue to hold players waiting to join the game.
            Queue<Player> waitingToJoinQ = new Queue<Player>();

            // Creating player instances with 100 health and unique gamer tags.
            Player p1 = new Player(100, "Venus103");
            Player p2 = new Player(100, "XxIrenexX");
            Player p3 = new Player(100, "SirenX");
            Player p4 = new Player(100, "FNAF_GOD_1987");

            // Players attempt to join the game.
            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            // Displaying players currently in the queue.
            Console.WriteLine("Players in the Q:");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }

            // Removing a player from the game.
            myGame.KickPlayer();

            // Checking if there is space in the game to add a player from the queue.
            myGame.CheckQueue(waitingToJoinQ);

            // Displaying the updated queue after attempting to add a player to the game.
            Console.WriteLine("\nPlayers in the Q");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }
        }
    }
}