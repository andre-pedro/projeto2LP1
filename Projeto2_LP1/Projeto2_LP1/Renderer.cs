using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Renderer
    {

        public void Render(Initializer init, Grid grid)
        {
            Console.Clear();

            for (int row = 0; row < 8; row++)
            {
                Console.WriteLine("\n");

                for (int column = 0; column < 8; column++)
                {
                    if (column == 0)
                    {
                        Console.Write(" ");
                    }
                    foreach (IGameObject thing in grid.array[row, column])
                    {
                        if (thing == init.player)
                        {
                            Console.Write(thing.ToString());
                        }
                        if (thing == init.exit)
                        {
                            Console.Write(thing.ToString());
                        }
                        if (thing == init.trap1)
                        {
                            Console.Write(thing.ToString());
                        }
                        if (thing == init.trap2)
                        {
                            Console.Write(thing.ToString());
                        }
                        if (thing == init.trap3)
                        {
                            Console.Write(thing.ToString());
                        }
                        if (thing == init.npc)
                        {
                            Console.Write(thing.ToString());
                        }
                    }
                    for (int i = 5 - grid.array[row, column].Count(); i > 0; i--)
                    {
                        if (grid.array[row, column].Contains(init.exit))
                        {
                            // Não imprime (para não sobrepor exit)
                        }
                        else
                        {
                            if (grid.array[row, column].Contains(init.player))
                            {
                                Console.Write(". ");
                            }
                        }
                    }

                    if (column < 7)
                    {
                        Console.Write("\t");
                    }

                    if (column == 7)
                    {
                        if (row == 0)
                        {
                            Console.Write($"          [Status]        " +
                                $"                [Info]              ");
                        }
                        if (row == 1)
                        {
                            Console.Write($"    Current Level:     ");
                            Console.Write($"{init.level:000}              ");
                            Console.ResetColor();
                            Console.Write($"Player - ");
                            Console.Write($"\u2302              ");
                        }
                        if (row == 2)
                        {
                            Console.Write($"    Player HP:         ");
                            Console.Write($"{init.player.Hp:000}             ");
                            Console.Write($"  Empty - ." +
                                $"               ");
                        }
                        if (row == 3)
                        {
                            Console.Write($"                    ");
                            Console.Write($"                      Exit - ");
                            Console.Write($"E X I T !              ");
                        }
                        if (row == 4)
                        {
                            Console.Write($"                             ");
                            Console.Write($"             Trap - ");
                            Console.Write($"\u25B2   ");
                        }
                        if (row == 5)
                        {
                            Console.Write($"                             ");
                            Console.Write($"             Food - ");
                            Console.Write($"\u2665   ");
                        }
                        if (row == 6)
                        {
                            Console.Write($"                             ");
                            Console.Write($"      Neutral NPC - ");
                            Console.Write($"\u25CA              ");
                        }
                        if (row == 7)
                        {
                            Console.Write($"                             ");
                            Console.Write($"      Hostile NPC - ");
                            Console.Write($"\u2666              ");
                        }
                        Console.Write("\n");
                    }
                    for (int i = 5 - grid.array[row, column].Count(); i > 0; i--)
                    {
                        if (grid.array[row, column].Contains(init.exit))
                        {
                            // Não imprime (para não sobrepor exit)
                        }
                        else
                        {
                            if (grid.array[row, column].Contains(init.player)) /*&&
                                (grid.array[grid.playerX - 1, grid.playerY].Count() > 0) &&
                                (grid.array[grid.playerX + 1, grid.playerY].Count() > 0) &&
                                (grid.array[grid.playerX, grid.playerY - 1].Count() > 0) &&
                                (grid.array[grid.playerX, grid.playerY + 1].Count() > 0))*/

                            {
                                Console.Write(". ");
                            }
                            else
                            {
                                Console.Write("~ ");
                            }
                        }
                    }

                }
            }
            Console.SetCursorPosition(16, 26);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" [Surroundings]");
            Console.ResetColor();

            Console.SetCursorPosition(55, 35);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" [Messages]");
            Console.ResetColor();
        }
    }
}