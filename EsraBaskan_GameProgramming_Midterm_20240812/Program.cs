//Created collaboratively using Windsurf and ChatGPT
using System;
using System.Threading;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSlowly("\n*********************************", 5);
            WriteSlowly("\n*     The Lost Relic           *", 5);
            WriteSlowly("\n*     A Mystical Journey       *", 5);
            WriteSlowly("\n*********************************\n\n", 5);

            WriteSlowly("Legends tell of the Relic of Eternity, hidden deep within the Forbidden Forest.\n", 20);
            WriteSlowly("It is said to grant the heart's deepest desire but at a cost unknown to man.\n", 20);
            
            string playerName;
            do
            {
                WriteSlowly("\nEnter your name, brave seeker: ", 10);
                playerName = Console.ReadLine()?.Trim() ?? "";
                if (string.IsNullOrWhiteSpace(playerName))
                {
                    WriteSlowly("We must know your name to begin this journey...\n", 10);
                }
            } while (string.IsNullOrWhiteSpace(playerName));

            WriteSlowly($"\nWelcome, {playerName}. As the first rays of dawn pierce the misty woods,", 15);
            WriteSlowly("\nyou tighten your pack and take the first step into the unknown...", 15);
            Thread.Sleep(1000);
            Console.Clear();

            var game = new Game(playerName);
            game.Start();
        }

        private static void WriteSlowly(string text, int delay = 5)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }
    }
}
