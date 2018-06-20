using System;

namespace Projeto2_LP1
{
    /// <summary>
    /// Esta classe é responsavél pela a impressão na consola os creditos do jogo
    /// e utiliza um método para tal.
    /// </summary>
    class Credits
    {
        /// <summary>
        /// Através da utilização de métodos que a classe Console fornece o método
        /// Print(); posiciona a informação e o tipo da mesma num sítio específico.
        /// Os métodos utilizados da classe Console são:
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
        public void Print()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("╔═════════════════════════════════════════════════════" +
                "════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(56, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[Credits]");
            Console.ResetColor();
            Console.SetCursorPosition(34, 4);
            Console.WriteLine("- Universidade Lusófona de Humanidades e Tecnologias - ");
            Console.SetCursorPosition(27, 6);
            Console.WriteLine("This project was made by André Pedro," +
                " André Santos and Tiago Alves.");
            Console.SetCursorPosition(48, 8);
            Console.WriteLine("Press any Key to continue...");

            Console.SetCursorPosition(0, 10);
            Console.WriteLine("╚═════════════════════════════════════════════════════" +
                "════════════════════════════════════════════════════════════════════╝");
            Console.ReadKey();
        }
    }
}
