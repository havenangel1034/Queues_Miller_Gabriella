namespace Queues_Miller_Gabriella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game(50, 49);

            Queue<Player> waitingToJoinQ = new Queue<Player>();

            Player p1 = new Player(100, "Venus103");
            Player p2 = new Player(100, "XxIrenexX");
            Player p3 = new Player(100, "SirenX");
            Player p4 = new Player(100, "FNAF_GOD_1987");

            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            Console.WriteLine("Players in the Q:");
            foreach(Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }

            myGame.kICKpLAYER();
            myGame.CheckQueue(waitingToJoinQ);

            Console.WriteLine("\nPlayers in the Q");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }
        }
    }
}