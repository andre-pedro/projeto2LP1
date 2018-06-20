using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Renderer
    {
        public bool explored = false;

        public void Render(Initializer init, Grid grid)
        {
            Console.Clear();

            for (int row = 0; row < 8; row++)
            {
                Console.WriteLine("\n");

                for (int column = 0; column < 8; column++)
                {
                    foreach (IGameObject thing in grid.array[row, column])
                    {
                        Console.ResetColor();
                        if (thing == init.player)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(thing.ToString());
                            Console.ResetColor();
                        }
                        if (thing == init.exit)
                        {
                            if (grid.array[grid.playerX, grid.playerY].Contains(init.exit))
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(thing.ToString());
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("~ ~ ~ ~ ~ ");
                            }
                        }
                        if (thing == init.trap1)
                        {
                            if (grid.array[grid.playerX, grid.playerY].Contains(init.trap1))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(thing.ToString());
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("~ ");
                            }
                        }
                        if (thing == init.trap2)
                        {
                            if (grid.array[grid.playerX, grid.playerY].Contains(init.trap2))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(thing.ToString());
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("~ ");
                            }
                        }
                        if (thing == init.trap3)
                        {
                            if (grid.array[grid.playerX, grid.playerY].Contains(init.trap3))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(thing.ToString());
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("~ ");
                            }
                        }
                        if (thing == init.npc)
                        {
                            if (grid.array[grid.playerX, grid.playerY].Contains(init.npc))
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(thing.ToString());
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("~ ");
                            }
                        }
                        if (thing == init.food1)
                        {
                            if (grid.array[grid.playerX, grid.playerY].Contains(init.food1))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(thing.ToString());
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("~ ");
                            }
                        }
                        if (thing == init.food2)
                        {
                            if (grid.array[grid.playerX, grid.playerY].Contains(init.food2))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(thing.ToString());
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("~ ");
                            }
                        }
                        if (thing == init.food3)
                        {
                            if (grid.array[grid.playerX, grid.playerY].Contains(init.food3))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(thing.ToString());
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("~ ");
                            }
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
                            else
                            {
                                Console.Write("~ ");
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
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{init.level:000}              ");
                            Console.ResetColor();
                            Console.Write($"Player - ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write($"\u2302              ");
                            Console.ResetColor();
                        }
                        if (row == 2)
                        {
                            Console.Write($"    Player HP:         ");
                            if (init.player.Hp > 50)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else if (init.player.Hp <= 50 && init.player.Hp > 20)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            else if (init.player.Hp <= 20 && init.player.Hp > 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else if (init.player.Hp <= 5)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            Console.Write($"{init.player.Hp:000}             ");
                            Console.ResetColor();
                            Console.Write($"  Empty - ." +
                                $"               ");
                        }
                        if (row == 3)
                        {
                            Console.Write($"                    ");
                            Console.Write($"                      Exit - ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"E X I T !              ");
                            Console.ResetColor();
                        }
                        if (row == 4)
                        {
                            Console.Write($"                             ");
                            Console.Write($"             Trap - ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"\u25B2   ");
                            Console.ResetColor();
                        }
                        if (row == 5)
                        {
                            Console.Write($"                             ");
                            Console.Write($"             Food - ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"\u2665   ");
                            Console.ResetColor();
                        }
                        if (row == 6)
                        {
                            Console.Write($"                             ");
                            Console.Write($"      Neutral NPC - ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"\u25CA              ");
                            Console.ResetColor();
                        }
                        if (row == 7)
                        {
                            Console.Write($"                             ");
                            Console.Write($"      Hostile NPC - ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"\u2666              ");
                            Console.ResetColor();
                        }
                        Console.Write("\n");
                    }
                }
            }
            Console.SetCursorPosition(0, 25);
            Console.WriteLine("╔═════════════════════════════════════════════════════" +
                "══════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(16, 26);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[Surroundings]");
            Console.ResetColor();

            Console.SetCursorPosition(0, 35);
            Console.WriteLine("╚═════════════════════════════════════════════════════" +
                "══════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(55, 35);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[Messages]");
            Console.ResetColor();

            if (grid.moved != "NONE")
            {
                Console.SetCursorPosition(51, 37);
                Console.WriteLine($" - I walked {grid.moved}.");
            }

            // Verificacao trap1
            if (grid.array[grid.playerX, grid.playerY].Contains(init.trap1))
            {
                Console.SetCursorPosition(44, 37);
                Console.WriteLine($" - I've paid a recurso (-78 HP).");
            }
            // Verificacao trap2
            if (grid.array[grid.playerX, grid.playerY].Contains(init.trap2))
            {
                Console.SetCursorPosition(42, 37);
                Console.WriteLine($" - I've stepped on a spike (-22 HP).");
            }
            // Verificacao trap3
            if (grid.array[grid.playerX, grid.playerY].Contains(init.trap3))
            {
                Console.SetCursorPosition(42, 37);
                Console.WriteLine($" - I've fallen into a hole (-10 HP).");
            }

            Console.SetCursorPosition(85, 26);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[Controls]");
            Console.ResetColor();
            Console.SetCursorPosition(82, 28);
            Console.WriteLine("  W - Move North");
            Console.SetCursorPosition(82, 29);
            Console.WriteLine("  A - Move West");
            Console.SetCursorPosition(82, 30);
            Console.WriteLine("  D - Move East");
            Console.SetCursorPosition(82, 31);
            Console.WriteLine("  S - Move South");
            Console.SetCursorPosition(82, 32);
            Console.WriteLine("  E - Eat Food");
            Console.SetCursorPosition(82, 33);
            Console.WriteLine("  Q - Quit Game");
        }
    }
}