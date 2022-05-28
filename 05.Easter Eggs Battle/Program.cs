using System;

namespace _05.Easter_Eggs_Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playrOneEggs = int.Parse(Console.ReadLine());
            int playerTwoEggs = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "one")
                {
                    playerTwoEggs--;
                }
                else if (command == "two")
                {
                    playrOneEggs--;
                }

                if (playrOneEggs == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {playerTwoEggs} eggs left.");
                    break;
                }
                else if (playerTwoEggs == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {playrOneEggs} eggs left.");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "End")
            {
                Console.WriteLine($"Player one has {playrOneEggs} eggs left.");
                Console.WriteLine($"Player two has {playerTwoEggs} eggs left.");
            }
        }
    }
}
