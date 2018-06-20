using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Surroundings
    {
        public void Scan(Initializer init, Grid grid)
        {
            Console.SetCursorPosition(6, 28);
            // Get List of Items at North
            Console.Write($" - North");
            if (grid.playerX > 0)
            {
                if (grid.array[grid.playerX - 1, grid.playerY].Count() > 0)
                {
                    foreach (IGameObject thing in grid.array[grid.playerX - 1, grid.playerY])
                    {
                        if (thing != init.player)
                        {
                            Console.Write($" has {thing.Name}.");
                        }
                    }
                }
                else
                {
                    Console.Write(" is empty.");
                }
            }
            else
            {
                Console.Write(" has a huge wall!");
            }
            // Get List of Items at South
            Console.SetCursorPosition(6, 29);
            Console.Write($" - South");
            if (grid.playerX < 7)
            {
                if (grid.array[grid.playerX + 1, grid.playerY].Count() > 0)
                {
                    foreach (IGameObject thing in grid.array[grid.playerX + 1, grid.playerY])
                    {
                        if (thing != init.player)
                        {
                            Console.Write($" has {thing.Name}.");
                        }
                    }
                }
                else
                {
                    Console.Write(" is empty.");
                }
            }
            else
            {
                Console.Write(" has a huge wall!");
            }
            // Get List of Items at West
            Console.SetCursorPosition(6, 30);
            Console.Write($" - West");
            if (grid.playerY > 0)
            {
                if (grid.array[grid.playerX, grid.playerY - 1].Count() > 0)
                {
                    foreach (IGameObject thing in grid.array[grid.playerX, grid.playerY - 1])
                    {
                        if (thing != init.player)
                        {
                            Console.Write($" has {thing.Name}.");
                        }
                    }
                }
                else
                {
                    Console.Write(" is empty.");
                }
            }
            else
            {
                Console.Write(" has a huge wall!");
            }
            // Get List of Items at East
            Console.SetCursorPosition(6, 31);
            Console.Write($" - East");
            if (grid.playerY < 7)
            {
                if (grid.array[grid.playerX, grid.playerY + 1].Count() > 0)
                {
                    foreach (IGameObject thing in grid.array[grid.playerX, grid.playerY + 1])
                    {
                        if (thing != init.player)
                        {
                            Console.Write($" has {thing.Name}.");
                        }
                    }
                }
                else
                {
                    Console.Write(" is empty.");
                }
            }
            else
            {
                Console.Write(" has a huge wall!");
            }
            // Get List of Items at current position
            if (grid.array[grid.playerX, grid.playerY].Count() > 1) // Player mais outra coisa
            {
                foreach (IGameObject thing in grid.array[grid.playerX, grid.playerY])
                {
                    if (thing != init.player)
                    {
                        Console.SetCursorPosition(6, 32);
                        Console.WriteLine($" - I see {thing.Name}!");
                    }
                }
            }
            else
            {
                Console.SetCursorPosition(6, 32);
                Console.WriteLine(" - There's absolutely nothing here!");
            }

            // Regressar a posicao normal
            Console.SetCursorPosition(0, 37);
        }
    }
}