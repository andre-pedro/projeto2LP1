using System;
using System.Collections.Generic;

namespace Projeto2_LP1
{

    /// <summary>
    /// Classe que irá mostra ao jogador o Main Menu, é a primeira classe visível 
    /// pela a parte do jogador.
    /// </summary>
    class MainMenu
    {
        static int selectedLine = 0;

        /// <summary>
        /// Método que irá desenhar na consola o menu com as várias opções ao 
        /// jogador.
        /// </summary>
        public static void Display()
        {
            Initializer init = new Initializer();

            ///Instância de classe que permite iniciar o ciclo do jogo assim que
            ///o jogador escolher esta opção.
            GameLoop gameLoop = new GameLoop();

            ///Instância de classe que permite mostrar os créditos do jogo.
            Credits credits = new Credits();

            ///Instância de classe que permite mostrar ao jogador o top 10 de 
            ///pontuações do jogo.
            HighScores highScores = new HighScores();

            List<string> menuLines = new List<string>() {
                "   New Game     ",
                "   High Scores  ",
                "   Credits      ",
                "   Quit         "
            };

            ///boolenado de verificação se jogador já escolhe alguma opção do 
            ///menu.
            bool chosingMenu = true;

            ///Enquanto o jogador estiver no Menu
            while (chosingMenu)
            {
                Console.Clear();

                string selected = DisplayMenu(menuLines);
                if (selected == "   New Game     ")
                {
                    ///Permite limpar a visualização da consola
                    Console.Clear();
                    init.Init();
                    gameLoop.NewGame(init);
                    Console.Clear();
                    chosingMenu = false;
                }
                else if (selected == "   High Scores  ")
                {
                    ///Permite limpar a visualização da consola
                    Console.Clear();

                    // Creditos

                    highScores.Print();
                    Console.Clear();
                }
                else if (selected == "   Credits      ")
                {
                    ///Permite limpar a visualização da consola
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

        /// <summary>
        /// Método que irá desenhar na consola o menu visível ao jogador, os 
        /// botões e o titulo do jogo.
        /// </summary>
        /// <param name="lines">As linhas dos botões do menu.</param>
        /// <returns>Este método nao retorna nada.</returns>
        private static string DisplayMenu(List<string> lines)
        {

            ///Desenha o titulo do jogo "RogueLike".
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("╔═════════════════════════════════════════════════════" +
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

            ///Permite alterar as cores do titulo enter branco, preto, e cizento
            ///escuro.
            for (int i = 0; i < lines.Count; i++)
            {
                if (i == selectedLine)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine();
                    Console.SetCursorPosition(55, 12 + 3 * i);
                    Console.WriteLine(lines[i]);
                    Console.WriteLine();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine();
                    Console.SetCursorPosition(55, 12 + 3 * i);
                    Console.WriteLine(lines[i]);
                    Console.WriteLine();
                }
                Console.ResetColor();
            }

            ///Visualização dos botões e respecitvas opções.
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 25);
            Console.WriteLine("╚═════════════════════════════════════════════════════" +
                "════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(2, 23);
            if (selectedLine == 0)
            {
                Console.WriteLine("Start the game");
            }
            if (selectedLine == 1)
            {
                Console.WriteLine("View high scores");
            }
            if (selectedLine == 2)
            {
                Console.WriteLine("Look at the credits");
            }
            if (selectedLine == 3)
            {
                Console.WriteLine("Quit the game");
            }
            Console.ResetColor();
            Console.WriteLine();

            Console.SetCursorPosition(0, 23);

            ConsoleKeyInfo input = Console.ReadKey();

            if (input.Key == ConsoleKey.S)
            {
                if (selectedLine == lines.Count - 1)
                {
                    ///Mantêm a mesma selecão.
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
                    /// Mantêm a mesma selecão
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