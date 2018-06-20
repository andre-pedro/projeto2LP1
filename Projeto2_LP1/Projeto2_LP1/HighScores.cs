using System;

namespace Projeto2_LP1
{
    /// <summary>
    /// Esta classe ira imprimir ao jogador na consola os HighScores do jogo.
    /// </summary>
    class HighScores
    {
        /// <summary>
        /// É criada uma instância da classe HighScoresManager que permite 
        /// revelar os jogadores que conseguiram obter melhor pontuação.
        /// </summary>
        HighScoresManager hsm = new HighScoresManager();

        /// <summary>
        /// Através da utilização de métodos que a classe Console fornece ao método
        /// Print(); permite posicionar o nome do jogador e as melhores pontuações
        /// na consola. 
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
            Console.SetCursorPosition(55, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[High Scores]");
            Console.ResetColor();

            int row = 4;

            ///Pecorre o ficheiro .txt e imprimi o nome e o respectivo score.
            foreach (Tuple<string, float> highscore in hsm.GetScores())
            {
                row++;
                Console.SetCursorPosition(45, row);
                Console.WriteLine($"Name: {highscore.Item1, -18}" + $"Score: {highscore.Item2}");
            }

            Console.SetCursorPosition(48, 20);
            Console.WriteLine("Press any Key to continue...");

            Console.SetCursorPosition(0, 21);
            Console.WriteLine("╚═════════════════════════════════════════════════════" +
                "════════════════════════════════════════════════════════════════════╝");

            Console.ReadKey();
        }
    }
}
