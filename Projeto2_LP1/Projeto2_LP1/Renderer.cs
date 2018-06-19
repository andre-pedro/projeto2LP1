using System;
using System.Linq;


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
                        Console.ResetColor();
                        if (thing == init.player)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(thing.ToString());
                            Console.ResetColor();
                        }
                        if (thing == init.exit)
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
        }
    }
}