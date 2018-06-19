using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class GameOver
    {
        public void Die(Initializer init)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine(" ╔═════════════════════════════════════════════════════" +
                "════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(55, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" [Game Over]");
            Console.ResetColor();
            Console.SetCursorPosition(42, 4);
            Console.WriteLine($" You've died! You made it till level {init.level}!");
            Console.SetCursorPosition(48, 6);
            Console.WriteLine($" Press any Key to continue...");

            Console.SetCursorPosition(0, 9);
            Console.WriteLine(" ╚═════════════════════════════════════════════════════" +
                "════════════════════════════════════════════════════════════════════╝");
            Console.ReadKey();
            Console.SetCursorPosition(48, 6);
            Environment.Exit(0);
        }
    }
}