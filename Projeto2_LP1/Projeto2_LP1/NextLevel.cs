using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class NextLevel
    {
        public bool HasLeveled(Initializer init, Grid grid)
        {
            if (grid.array[grid.playerX, grid.playerY].Contains(init.player) &&
                grid.array[grid.playerX, grid.playerY].Contains(init.exit) && init.player.Hp > 0)
            {
                init.level++;
                Console.Clear();
                Console.SetCursorPosition(55, 2);
                Console.WriteLine(" [Next Level]");
                Console.ResetColor();
                Console.SetCursorPosition(37, 4);
                Console.WriteLine($" You've reached the EXIT! You're now on level {init.level}!");
                Console.SetCursorPosition(48, 6);
                Console.WriteLine($" Press any Key to continue...");
                Console.ReadKey();
                Console.Clear();
                return true;
            }
            return false;
        }
    }
}
