using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Controls
    {
        Grid grid = new Grid();
        Initializer init = new Initializer();

        public void CheckInputs(Initializer init, Grid grid)
        {
            bool playing = true;
            bool quitConfirm = true;

            while (playing == true)
            {
                ConsoleKeyInfo selectedKey = Console.ReadKey();

                switch (selectedKey.Key)
                {
                    case ConsoleKey.W:
                        if (grid.playerX > 0)
                        {
                            grid.array[grid.playerX, grid.playerY].Remove(init.player);
                            grid.playerX -= 1;
                            grid.array[grid.playerX, grid.playerY].Add(init.player);
                            playing = false;
                            grid.moved = "NORTH";
                        }
                        Console.SetCursorPosition(43, 37);
                        Console.WriteLine(" - I can't move on that direction!");
                        break;
                    case ConsoleKey.S:
                        if (grid.playerX < 7)
                        {
                            grid.array[grid.playerX, grid.playerY].Remove(init.player);
                            grid.playerX += 1;
                            grid.array[grid.playerX, grid.playerY].Add(init.player);
                            playing = false;
                            grid.moved = "SOUTH";
                        }
                        Console.SetCursorPosition(43, 37);
                        Console.WriteLine(" - I can't move on that direction!");
                        break;
                    case ConsoleKey.A:
                        if (grid.playerY > 0)
                        {
                            grid.array[grid.playerX, grid.playerY].Remove(init.player);
                            grid.playerY -= 1;
                            grid.array[grid.playerX, grid.playerY].Add(init.player);
                            playing = false;
                            grid.moved = "WEST";
                        }
                        Console.SetCursorPosition(43, 37);
                        Console.WriteLine(" - I can't move on that direction!");
                        break;
                    case ConsoleKey.D:
                        if (grid.playerY < 7)
                        {
                            grid.array[grid.playerX, grid.playerY].Remove(init.player);
                            grid.playerY += 1;
                            grid.array[grid.playerX, grid.playerY].Add(init.player);
                            playing = false;
                            grid.moved = "EAST";
                        }
                        Console.SetCursorPosition(43, 37);
                        Console.WriteLine(" - I can't move on that direction!");
                        break;
                    case ConsoleKey.E:
                        if (grid.array[grid.playerX, grid.playerY].Contains(init.food1))
                        {
                            init.player.Hp += init.food1.Heal;
                            grid.array[grid.playerX, grid.playerY].Remove(init.food1);
                            playing = false;
                        }
                        if (grid.array[grid.playerX, grid.playerY].Contains(init.food2))
                        {
                            init.player.Hp += init.food2.Heal;
                            grid.array[grid.playerX, grid.playerY].Remove(init.food2);
                            playing = false;
                        }
                        if (grid.array[grid.playerX, grid.playerY].Contains(init.food3))
                        {
                            init.player.Hp += init.food3.Heal;
                            grid.array[grid.playerX, grid.playerY].Remove(init.food3);
                            playing = false;
                        }
                        break;
                    case ConsoleKey.Q:
                        Console.SetCursorPosition(42, 37);
                        Console.WriteLine("Are you sure you want to quit? (Y/N)");
                        while (quitConfirm)
                        {
                            ConsoleKeyInfo quitKey = Console.ReadKey();
                            if (selectedKey.Key != ConsoleKey.Y ||
                                selectedKey.Key != ConsoleKey.N)
                            {
                                Console.SetCursorPosition(42, 37);
                                Console.WriteLine("Are you sure you want to quit? (Y/N)");
                            }
                            else
                            {
                                break;
                            }

                            switch (quitKey.Key)
                            {
                                case ConsoleKey.Y:
                                    Console.SetCursorPosition(42, 39);
                                    Environment.Exit(0);
                                    break;
                                case ConsoleKey.N:
                                    quitConfirm = false;
                                    Console.SetCursorPosition(50, 39);
                                    Console.WriteLine("Quiting aborted!");
                                    break;
                            }
                        }
                        break;
                }
            }
        }
    }
}