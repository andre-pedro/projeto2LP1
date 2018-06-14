using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Menu
    {
        static int selectedLine = 0;

        public static void Display()
        {
            List<string> menuLines = new List<string>() {
                "New Game",
                "High Scores",
                "Credits",
                "Quit"
            };

            Console.CursorVisible = false;

            while (true)
            {
                // Limpar Consola
                Console.Clear();

                string selected = DisplayMenu(menuLines);
                if (selected == "New Game")
                {
                    // Limpar Consola
                    Console.Clear();

                    // Render
                    Renderer render = new Renderer();
                    Renderer.Render();

                    // Instanciar Player
                    Player player = new Player();
                    // Instanciar NPC
                    NPC npc = new NPC();

                    // Testar metodos das classes PLayer e NPC
                    Console.WriteLine("Player Direction: " + player.Move());
                    Console.WriteLine("NPC Direction: " + npc.Move());
                }
                else if (selected == "High Scores")
                {
                    // Limpar Consola
                    Console.Clear();

                    // Creditos

                    Console.WriteLine("High Scores");
                    Console.WriteLine();
                    Console.WriteLine("High scores are not yet available...");
                    Console.WriteLine("______________");
                    Console.WriteLine();
                    Console.WriteLine("Controls:");
                    Console.WriteLine();
                    Console.WriteLine("ENTER - Go Back");
                    Console.ReadKey();
                }
                else if (selected == "Credits")
                {
                    // Limpar Consola
                    Console.Clear();

                    // Creditos
                    Console.WriteLine("Universidade Lusófona de Humanidades e Tecnologias");
                    Console.WriteLine("__________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine("Project made for LP1 by:");
                    Console.WriteLine();
                    Console.WriteLine("André Pedro");
                    Console.WriteLine("André Santos");
                    Console.WriteLine("Tiago Alves");
                    Console.WriteLine("______________");
                    Console.WriteLine();
                    Console.WriteLine("The teacher:");
                    Console.WriteLine();
                    Console.WriteLine("Nuno Fachada");
                    Console.WriteLine("______________");
                    Console.WriteLine();
                    Console.WriteLine("Controls:");
                    Console.WriteLine();
                    Console.WriteLine("ENTER - Go Back");
                    Console.ReadKey();
                }
                else if (selected == "Quit")
                {
                    Environment.Exit(0);
                }
            }
        }

        private static string DisplayMenu(List<string> lines)
        {
            Console.WriteLine("ROGUELIKE GAME");
            Console.WriteLine("______________");
            Console.WriteLine();

            for (int i = 0; i < lines.Count; i++)
            {
                if (i == selectedLine)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.Write("=>   ");
                    Console.Write(lines[i]);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(lines[i]);
                }
                Console.ResetColor();
            }

            Console.WriteLine("______________");
            Console.WriteLine();
            Console.WriteLine("Controls:");
            Console.WriteLine();
            Console.WriteLine("W, A, S, D - Movement");
            Console.WriteLine();
            Console.WriteLine("ENTER - Selection");
            Console.WriteLine();
            Console.WriteLine("______________");
            Console.WriteLine();
            Console.Write("Action: ");
            if (selectedLine == 0) Console.Write("Start the game...");
            if (selectedLine == 1) Console.Write("View high scores...");
            if (selectedLine == 2) Console.Write("Look at the credits...");
            if (selectedLine == 3) Console.Write("Exit the game...");
            Console.WriteLine();

            ConsoleKeyInfo input = Console.ReadKey();

            if (input.Key == ConsoleKey.S)
            {
                if (selectedLine == lines.Count - 1)
                {
                    // Mantem a mesma selecao
                }
                else
                {
                    selectedLine++;
                }
            }
            else if (input.Key == ConsoleKey.W)
            {
                if (selectedLine <= 0)
                {
                    // Mantem a mesma selecao
                }
                else
                {
                    selectedLine--;
                }
            }
            else if (input.Key == ConsoleKey.Enter)
            {
                return lines[selectedLine];
            }
            else
            {
                return null;
            }
            return null;

        }
    }
}
