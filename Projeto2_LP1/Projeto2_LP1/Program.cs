using System;
using System.Text;

namespace Projeto2_LP1
{

    /// <summary>
    /// Classe aonde irá decorrer todo o projecto
    /// </summary>
    class Program
    {

        /// <summary>
        /// Método que irá "chamar" as classes necessárias através de variáveis
        /// de instância para efectuar o ciclo de jogo
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.OutputEncoding = Encoding.UTF8;

            Console.CursorVisible = false;

            MainMenu.Display();
        }
    }
}