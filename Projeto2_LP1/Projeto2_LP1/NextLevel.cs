using System;

namespace Projeto2_LP1
{
    class NextLevel
    {
        public bool HasLeveled(Initializer init, Grid grid)
        {
            if (grid.array[grid.playerX, grid.playerY].Contains(init.player) &&
                grid.array[grid.playerX, grid.playerY].Contains(init.exit) && init.player.Hp > 0)
            {
                init.exit.Explored = false;
                init.trap1.Explored = false;
                init.trap2.Explored = false;
                init.trap3.Explored = false;
                init.food1.Explored = false;
                init.food2.Explored = false;
                init.food3.Explored = false;
                init.trap1.FallenInto = false;
                init.trap2.FallenInto = false;
                init.trap3.FallenInto = false;
                init.npc.Explored = false;
                init.map.Explored = false;
                init.level++;
                Console.Clear();
                Console.SetCursorPosition(0, 1);
                Console.WriteLine(" ╔═════════════════════════════════════════════════════" +
                    "════════════════════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(55, 2);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" [Next Level]");
                Console.ResetColor();
                Console.SetCursorPosition(37, 4);
                Console.WriteLine($" You've reached the EXIT! You're now on level {init.level}!");
                Console.SetCursorPosition(48, 6);
                Console.WriteLine($" Press any Key to continue...");

                Console.SetCursorPosition(0, 9);
                Console.WriteLine(" ╚═════════════════════════════════════════════════════" +
                    "════════════════════════════════════════════════════════════════════╝");
                Console.ReadKey();
                Console.Clear();
                return true;
            }
            return false;
        }
    }
}
