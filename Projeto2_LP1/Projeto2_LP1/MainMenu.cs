using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Projeto2_LP1
{
    class MainMenu
    {
        static Random random = new Random();

        Grid grid = new Grid();
        Renderer renderer = new Renderer();
        Surroundings scan = new Surroundings();
        Controls controls = new Controls();

        static int selectedLine = 0;

        public static void Display()
        {
            Renderer renderer = new Renderer();
            MainMenu start = new MainMenu();
            Credits credits = new Credits();
            HighScores highScores = new HighScores();
            Initializer init = new Initializer();

            List<string> menuLines = new List<string>() {
                "   New Game     ",
                "   High Scores  ",
                "   Credits      ",
                "   Quit         "
            };

            bool chosingMenu = true;

            while (chosingMenu)
            {
                Console.Clear();

                string selected = DisplayMenu(menuLines);
                if (selected == "   New Game     ")
                {
                    // Limpar Consola
                    Console.Clear();

                    init.Init();
                    start.NewGame(init);
                    Console.Clear();
                    chosingMenu = false;
                }
                else if (selected == "   High Scores  ")
                {
                    // Limpar Consola
                    Console.Clear();

                    // Creditos

                    highScores.Print();
                    Console.Clear();
                }
                else if (selected == "   Credits      ")
                {
                    // Limpar Consola
                    Console.Clear();

                    credits.Print();
                    Console.Clear();
                }
                else if (selected == "   Quit         ")
                {
                    Environment.Exit(0);
                }
            }
        }

        private static string DisplayMenu(List<string> lines)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 1);
            Console.WriteLine(" ╔═════════════════════════════════════════════════════" +
                "════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(35, 2);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" _____                             _      _  _          ");
            Console.SetCursorPosition(35, 3);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|  __ \\                           | |    (_)| |         ");
            Console.SetCursorPosition(35, 4);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("| |_/ /  ___    __ _  _   _   ___ | |     _ | | __  ___ ");
            Console.SetCursorPosition(35, 5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|    /  / _ \\  / _` || | | | / _ \\| |    | || |/ / / _ \\");
            Console.SetCursorPosition(35, 6);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("| |\\ \\ | (_) || (_| || |_| ||  __/| |____| ||   < |  __/");
            Console.SetCursorPosition(35, 7);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\\_| \\_| \\___/  \\__, | \\__,_| \\___|\\_____/|_||_|\\_\\ \\___|");
            Console.SetCursorPosition(35, 8);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("               ___/ /                                   ");
            Console.SetCursorPosition(35, 9);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("              |____/                                    ");
            Console.ResetColor();

            for (int i = 0; i < lines.Count; i++)
            {
                if (i == selectedLine)
                {
                    Console.WriteLine();
                    Console.SetCursorPosition(55, 12 + 3 * i);
                    Console.WriteLine(lines[i]);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.SetCursorPosition(55, 12 + 3 * i);
                    Console.WriteLine(lines[i]);
                    Console.WriteLine();
                }
            }

            Console.SetCursorPosition(1, 23);
            if (selectedLine == 0)
            {
                Console.WriteLine(" Start the game");
            }
            if (selectedLine == 1)
            {
                Console.WriteLine(" View high scores");
            }
            if (selectedLine == 2)
            {
                Console.WriteLine(" Look at the credits");
            }
            if (selectedLine == 3)
            {
                Console.WriteLine(" Quit the game");
            }
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

        public void NewGame(Initializer init)
        {
            Console.Clear();
            grid.CreateGrid(init);
            while (init.player.Hp > 0)
            {
                renderer.Render(init, grid);
                scan.Scan(init, grid);
                controls.CheckInputs(init, grid);
                init.player.Hp--;
                if (init.player.Hp > 100)
                {
                    init.player.Hp = 100;
                }
                // Verificacao trap1
                if (grid.array[grid.playerX, grid.playerY].Contains(init.trap1))
                {
                    init.player.Hp -= init.trap1.Damage;
                }
                // Verificacao trap2
                if (grid.array[grid.playerX, grid.playerY].Contains(init.trap2))
                {
                    init.player.Hp -= init.trap2.Damage;
                }
                // Verificacao trap3
                if (grid.array[grid.playerX, grid.playerY].Contains(init.trap3))
                {
                    init.player.Hp -= init.trap3.Damage;
                }
                // Verificacao food
                if (grid.array[grid.playerX, grid.playerY].Contains(init.food))
                {
                    init.player.Hp += init.food.Heal;
                    grid.array[grid.playerX, grid.playerY].Remove(init.food);
                }
                Console.Clear();
            }
        }
    }
}