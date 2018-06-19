using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Controls
    {
        public void CheckInputs(Initializer init, Grid world)
        {
            bool playing = true;
            bool quitConfirm = true;

            while (playing == true)
            {
                ConsoleKeyInfo selectedKey = Console.ReadKey();
                if (selectedKey.Key != ConsoleKey.W || selectedKey.Key != ConsoleKey.S ||
                    selectedKey.Key != ConsoleKey.A || selectedKey.Key != ConsoleKey.D ||
                    selectedKey.Key != ConsoleKey.Q)
                {
                    Console.SetCursorPosition(42, 37);
                    Console.WriteLine(" - Hummm... That doesn't seem right...");
                }
                else
                {
                    break;
                }

                switch (selectedKey.Key)
                {
                    case ConsoleKey.W:
                        if (world.playerX > 0)
                        {
                            world.array[world.playerX, world.playerY].Remove(init.player);
                            world.playerX -= 1;
                            world.array[world.playerX, world.playerY].Add(init.player);
                            playing = false;
                        }
                        Console.SetCursorPosition(43, 37);
                        Console.WriteLine(" - I can't move on that direction!");
                        break;
                    case ConsoleKey.S:
                        if (world.playerX < 7)
                        {
                            world.array[world.playerX, world.playerY].Remove(init.player);
                            world.playerX += 1;
                            world.array[world.playerX, world.playerY].Add(init.player);
                            playing = false;
                        }
                        Console.SetCursorPosition(43, 37);
                        Console.WriteLine(" - I can't move on that direction!");
                        break;
                    case ConsoleKey.A:
                        if (world.playerY > 0)
                        {
                            world.array[world.playerX, world.playerY].Remove(init.player);
                            world.playerY -= 1;
                            world.array[world.playerX, world.playerY].Add(init.player);
                            playing = false;
                        }
                        Console.SetCursorPosition(43, 37);
                        Console.WriteLine(" - I can't move on that direction!");
                        break;
                    case ConsoleKey.D:
                        if (world.playerY < 7)
                        {
                            world.array[world.playerX, world.playerY].Remove(init.player);
                            world.playerY += 1;
                            world.array[world.playerX, world.playerY].Add(init.player);
                            playing = false;
                        }
                        Console.SetCursorPosition(43, 37);
                        Console.WriteLine(" - I can't move on that direction!");
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
                                    break;
                            }
                        }
                        break;
                }
            }
        }
    }
}