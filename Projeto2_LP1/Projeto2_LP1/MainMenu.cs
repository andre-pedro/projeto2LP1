using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    /// <summary>
    /// Classe responsavél pelo o menu e sub-menus que são mostrados ao jogador.
    /// </summary>
    class MainMenu
    {
        static Random random = new Random();

        Grid grid = new Grid();
        Renderer renderer = new Renderer();

        static int selectedLine = 0;

        /// <summary>
        /// 
        /// </summary>
        public static void Display()
        {
            Renderer renderer = new Renderer();
            MainMenu start = new MainMenu();
            Initializer init = new Initializer();

            List<string> menuLines = new List<string>() {
                "New Game",
                "High Scores",
                "Credits",
                "Quit"
            };

            bool chosingMenu = true;

            Console.CursorVisible = false;

            while (chosingMenu)
            {
                // Limpar Consola
                Console.Clear();

                string selected = DisplayMenu(menuLines);
                if (selected == "New Game")
                {
                    // Limpar Consola
                    Console.Clear();

                    init.Init();
                    start.NewGame(init);
                    Console.Clear();
                    chosingMenu = false;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
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
            if (selectedLine == 0) Console.Write("Start the game");
            if (selectedLine == 1) Console.Write("View high scores");
            if (selectedLine == 2) Console.Write("Look at the credits");
            if (selectedLine == 3) Console.Write("Quit the game");
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="init"></param>
        public void NewGame(Initializer init)
        {
            Console.Clear();
            grid.CreateGrid(init);
            while (init.player.Hp > 0)
            {
                renderer.Render(init, grid);
                init.player.Hp--;
                Console.Clear();
            }
        }
    }
}
