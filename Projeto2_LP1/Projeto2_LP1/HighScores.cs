using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class HighScores
    {
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
            Console.SetCursorPosition(53, 4);
            Console.WriteLine("- Comming Soon - ");
            Console.SetCursorPosition(48, 6);
            Console.WriteLine("Press any Key to continue...");

            Console.SetCursorPosition(0, 8);
            Console.WriteLine("╚═════════════════════════════════════════════════════" +
                "════════════════════════════════════════════════════════════════════╝");
            Console.ReadKey();
        }
    }
}
