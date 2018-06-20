using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{

    /// <summary>
    /// Classe de visualização do projecto.
    /// </summary>
    class Renderer
    {
        public void Render(Initializer init, Grid grid)
        {
            Console.Clear();

            for (int row = 0; row < 8; row++)
            {
                Console.WriteLine("\n\n");

                for (int column = 0; column < 8; column++)
                {
                    if ((row > 0 && grid.array[row - 1, column].Contains(init.player)) ||
                       (row < 7 && grid.array[row + 1, column].Contains(init.player)) ||
                       (column > 0 && grid.array[row, column - 1].Contains(init.player)) ||
                       (column < 7 && grid.array[row, column + 1].Contains(init.player)) ||
                        grid.array[row, column].Contains(init.player))
                    {
                        grid.array[row, column].Explored = true;
                    }
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
                            if ((row > 0 && grid.array[row - 1, column].Contains(init.player)) ||
                               (row < 7 && grid.array[row + 1, column].Contains(init.player)) ||
                               (column > 0 && grid.array[row, column - 1].Contains(init.player)) ||
                               (column < 7 && grid.array[row, column + 1].Contains(init.player)) ||
                               grid.array[row, column].Contains(init.player))
                            {
                                init.exit.Explored = true;
                            }
                            if (init.exit.Explored)
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
                            if ((row > 0 && grid.array[row - 1, column].Contains(init.player)) ||
                               (row < 7 && grid.array[row + 1, column].Contains(init.player)) ||
                               (column > 0 && grid.array[row, column - 1].Contains(init.player)) ||
                               (column < 7 && grid.array[row, column + 1].Contains(init.player)) ||
                               grid.array[row, column].Contains(init.player))
                            {
                                init.trap1.Explored = true;
                            }
                            if (init.trap1.Explored)
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
                            if ((row > 0 && grid.array[row - 1, column].Contains(init.player)) ||
                               (row < 7 && grid.array[row + 1, column].Contains(init.player)) ||
                               (column > 0 && grid.array[row, column - 1].Contains(init.player)) ||
                               (column < 7 && grid.array[row, column + 1].Contains(init.player)) ||
                               grid.array[row, column].Contains(init.player))
                            {
                                init.trap2.Explored = true;
                            }
                            if (init.trap2.Explored)
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
                            if ((row > 0 && grid.array[row - 1, column].Contains(init.player)) ||
                               (row < 7 && grid.array[row + 1, column].Contains(init.player)) ||
                               (column > 0 && grid.array[row, column - 1].Contains(init.player)) ||
                               (column < 7 && grid.array[row, column + 1].Contains(init.player)) ||
                               grid.array[row, column].Contains(init.player))
                            {
                                init.trap3.Explored = true;
                            }
                            if (init.trap3.Explored)
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
                        if (thing == init.food1)
                        {
                            if ((row > 0 && grid.array[row - 1, column].Contains(init.player)) ||
                               (row < 7 && grid.array[row + 1, column].Contains(init.player)) ||
                               (column > 0 && grid.array[row, column - 1].Contains(init.player)) ||
                               (column < 7 && grid.array[row, column + 1].Contains(init.player)) ||
                               grid.array[row, column].Contains(init.player))
                            {
                                init.food1.Explored = true;
                            }
                            if (init.food1.Explored)
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
                            if ((row > 0 && grid.array[row - 1, column].Contains(init.player)) ||
                               (row < 7 && grid.array[row + 1, column].Contains(init.player)) ||
                               (column > 0 && grid.array[row, column - 1].Contains(init.player)) ||
                               (column < 7 && grid.array[row, column + 1].Contains(init.player)) ||
                               grid.array[row, column].Contains(init.player))
                            {
                                init.food2.Explored = true;
                            }
                            if (init.food2.Explored)
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
                            if ((row > 0 && grid.array[row - 1, column].Contains(init.player)) ||
                               (row < 7 && grid.array[row + 1, column].Contains(init.player)) ||
                               (column > 0 && grid.array[row, column - 1].Contains(init.player)) ||
                               (column < 7 && grid.array[row, column + 1].Contains(init.player)) ||
                               grid.array[row, column].Contains(init.player))
                            {
                                init.food3.Explored = true;
                            }
                            if (init.food3.Explored)
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
                        if (thing == init.npc)
                        {
                            if ((row > 0 && grid.array[row - 1, column].Contains(init.player)) ||
                               (row < 7 && grid.array[row + 1, column].Contains(init.player)) ||
                               (column > 0 && grid.array[row, column - 1].Contains(init.player)) ||
                               (column < 7 && grid.array[row, column + 1].Contains(init.player)) ||
                               grid.array[row, column].Contains(init.player))
                            {
                                init.npc.Explored = true;
                            }
                            if (init.npc.Explored)
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
                        if (thing == init.map)
                        {
                            if ((row > 0 && grid.array[row - 1, column].Contains(init.player)) ||
                               (row < 7 && grid.array[row + 1, column].Contains(init.player)) ||
                               (column > 0 && grid.array[row, column - 1].Contains(init.player)) ||
                               (column < 7 && grid.array[row, column + 1].Contains(init.player)) ||
                               grid.array[row, column].Contains(init.player))
                            {
                                init.map.Explored = true;
                            }
                            if (init.map.Explored)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
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
                            if (grid.array[row, column].Explored)
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
                }
            }

            Console.SetCursorPosition(0, 26);
            Console.WriteLine("╔═════════════════════════════════════════════════════" +
                "══════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(16, 27);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[Surroundings]");
            Console.ResetColor();

            Console.SetCursorPosition(0, 36);
            Console.WriteLine("╚═════════════════════════════════════════════════════" +
                "══════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(54, 37);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[Messages]");
            Console.ResetColor();

            if (grid.moved != "NONE")
            {
                Console.SetCursorPosition(51, 39);
                Console.WriteLine($"- I walked {grid.moved}.");
            }

            // Verificacao trap1
            if (grid.array[grid.playerX, grid.playerY].Contains(init.trap1))
            {
                Console.SetCursorPosition(47, 39);
                Console.WriteLine($"- I've paid a recurso.");
            }
            // Verificacao trap2
            if (grid.array[grid.playerX, grid.playerY].Contains(init.trap2))
            {
                Console.SetCursorPosition(45, 39);
                Console.WriteLine($"- I've stepped on a spike.");
            }
            // Verificacao trap3
            if (grid.array[grid.playerX, grid.playerY].Contains(init.trap3))
            {
                Console.SetCursorPosition(45, 39);
                Console.WriteLine("- I've fallen into a hole.");
            }

            Console.SetCursorPosition(85, 27);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[Controls]");
            Console.ResetColor();
            Console.SetCursorPosition(72, 29);
            Console.WriteLine("W - Move North");
            Console.SetCursorPosition(72, 30);
            Console.WriteLine("A - Move West");
            Console.SetCursorPosition(72, 31);
            Console.WriteLine("D - Move East");
            Console.SetCursorPosition(72, 32);
            Console.WriteLine("S - Move South");
            Console.SetCursorPosition(94, 29);
            Console.WriteLine("E - Pick Up / Use");
            Console.SetCursorPosition(94, 30);
            Console.WriteLine("I - More Info");
            Console.SetCursorPosition(94, 31);
            Console.WriteLine("Q - Quit Game");

            Console.SetCursorPosition(127, 1);
            Console.WriteLine("╔════════════════════════" +
                "══════════════════════════════════════╗");
            // Status
            Console.SetCursorPosition(140, 2);
            Console.Write("[Status]");
            Console.SetCursorPosition(135, 5);
            Console.Write($"Current Level: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{init.level:000}");
            Console.ResetColor();
            Console.SetCursorPosition(135, 8);
            Console.Write("Player HP: ");
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
            Console.Write($"{init.player.Hp:000}");
            Console.ResetColor();

            // Info
            Console.SetCursorPosition(172, 2);
            Console.Write("[Info]");
            Console.SetCursorPosition(168, 5);
            Console.Write("Player - ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2302");
            Console.ResetColor();
            Console.SetCursorPosition(168, 8);
            Console.Write("Explored - .");
            Console.SetCursorPosition(168, 11);
            Console.Write("Unexplored - ~");
            Console.SetCursorPosition(168, 14);
            Console.Write("Exit - ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("E X I T !");
            Console.ResetColor();
            Console.SetCursorPosition(168, 17);
            Console.Write("Trap - ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\u25B2");
            Console.ResetColor();
            Console.SetCursorPosition(168, 20);
            Console.Write("Food - ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\u2665");
            Console.ResetColor();
            Console.SetCursorPosition(168, 23);
            Console.Write("Neutral NPC - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\u25CA");
            Console.ResetColor();
            Console.SetCursorPosition(168, 26);
            Console.Write("Hostile NPC - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\u2666");
            Console.ResetColor();
            Console.SetCursorPosition(168, 29);
            Console.Write("Map - ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\u263C");
            Console.ResetColor();

            Console.SetCursorPosition(127, 36);
            Console.WriteLine("╚════════════════════════" +
                "══════════════════════════════════════╝");
        }
    }
}