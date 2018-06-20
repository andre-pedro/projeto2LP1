using System;

namespace Projeto2_LP1
{
    /// <summary>
    /// Através desta classe irá ser imprimido na consola o ecrã de fim de jogo.
    /// </summary>
    class GameOver
    {

        HighScoresManager hsm = new HighScoresManager();

        /// <summary>
        /// O método Die(); imprimi na consola ecrã de fim de jogo com o auxilio 
        /// de métodos que a classe Console fornece, posicionando a informação e
        /// o tipo da mesma num sítio específico. Os métodos utilizados da classe 
        /// Console são:
        /// - Clear(); - permite limpar a consola.
        /// - SetCursorPosition(); - indica aonde irá ser colocado a informação 
        /// desejada.
        /// - WriteLine(); - escreve no ecrã o que pretendemos e dá um enter 
        /// automático.
        /// - ForegroundColor(); - Permite a utilização de cores com os nossos 
        /// writelines();/writes();.
        /// - Resetcolor(); - limpa a cor anteriormente escolhida.
        /// - Readkey(); - Lê o input do utilizador para poder retroceder ao 
        /// Mainmenu.
        /// </summary>
        /// <param name="init"></param>
        public void Die(Initializer init)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine(" ╔═════════════════════════════════════════════════════" +
                "════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(55, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" [Game Over]");
            Console.ResetColor();
            Console.SetCursorPosition(42, 4);
            Console.WriteLine($" You've died! You made it till level {init.level}!");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine(" ╚═════════════════════════════════════════════════════" +
                "════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(48, 6);
            Console.Write("Insert your name here: ");
            string name = Console.ReadLine();
            // Add score and name
            hsm.AddScore(name, init.level);
            // Save to file
            hsm.Save();
            MainMenu.Display();
        }
    }
}