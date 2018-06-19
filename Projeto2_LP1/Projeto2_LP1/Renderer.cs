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
                    }
                }
                //not working
                /*    if (column < 7)
                    {
                        Console.Write("\t");
                    }
                }
            }
            Console.SetCursorPosition(55, 35);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" [Messages]");
            Console.ResetColor();*/
            }
        }
    }
}