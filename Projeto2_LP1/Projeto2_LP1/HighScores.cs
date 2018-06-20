using System;

namespace Projeto2_LP1
{
    class HighScores
    {
        HighScoresManager hsm = new HighScoresManager();

        public void Print()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("╔═════════════════════════════════════════════════════" +
                "════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(55, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[High Scores]");
            Console.ResetColor();

            int row = 4;

            foreach (Tuple<string, float> highscore in hsm.GetScores())
            {
                row++;
                Console.SetCursorPosition(45, row);
                Console.WriteLine($"Name: {highscore.Item1, -18}" + $"Score: {highscore.Item2}");
            }

            Console.SetCursorPosition(48, 20);
            Console.WriteLine("Press any Key to continue...");

            Console.SetCursorPosition(0, 21);
            Console.WriteLine("╚═════════════════════════════════════════════════════" +
                "════════════════════════════════════════════════════════════════════╝");

            Console.ReadKey();
        }
    }
}
