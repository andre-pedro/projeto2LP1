using System;

namespace Projeto2_LP1
{

    /// <summary>
    /// Classe que define os controlos bases para o jogador, o que irá permitir
    /// ao jogador mover-se na grid de jogo, e ao mesmo tempo informar o jogador 
    /// das teclas premidas e que direção se movimentou.  
    /// </summary>
    class Controls
    {
        /// <summary>
        /// É criada uma instânica desta classe para os controlos escolhidos que
        /// permitem a movimentação do jogador sejam impressas no ecrã.
        /// </summary>
        Grid grid = new Grid();

        /// <summary>
        /// É criada uma instância desta classe pois o jogador irá visualizar 
        /// informações do jogo, e mensagens dos controlos premidos e opções
        /// escolhidas
        /// </summary>
        Renderer renderer = new Renderer();

        /// <summary>
        /// É criada uma instância da classe Surroundings, pois quando o jogador
        /// pede as informações do jogo é necessário efectuar novamente uma 
        /// verificação da grid.
        /// /// </summary>
        Surroundings scan = new Surroundings();

        /// <summary>
        /// É criada uma instância da classe Initializer que permite inicializar
        /// os objectos que nelea contêm, neste caso informar ao jogador, o nome
        /// e dano causado das armadilhas disponívels no jogo.
        /// </summary>
        Initializer init = new Initializer();

        /// <summary>
        /// É criada uma instância da classe HighScoresManager que permite 
        /// verificar quando o jogador sai do jogo se ficou no top10.
        /// </summary>
        HighScoresManager hsm = new HighScoresManager();


        /// <summary>
        /// Este método irá verificar o input do jogador e efectuar
        /// a/s opção/ões que  correspondente a cada tecla.
        /// </summary>
        /// <param name="init">Parâmetro necessário para "desenhar" as movimentações
        /// do jogador.</param>
        /// <param name="grid">O método recebe a grid de jogo para o jogador 
        /// se poder movimentar.</param>
        public void CheckInputs(Initializer init, Grid grid)
        {

            ///Booleanos que indica se jogador se encontra a jogar.
            bool playing = true;

            ///Booleano que confirma se o jogador pretende sair do jogo.
            bool quitConfirm = true;

            ///Enquanto o booleano playing for verdadeiro irá sempre pedir input
            ///ao utilizador do que pretende fazer.
            while (playing == true)
            {

                ///Variável constante que permite usar o Console.ReadKey();
                ConsoleKeyInfo selectedKey = Console.ReadKey();

                ///Switch que irá altera consoante o input do utilizador.
                ///Caso o jogador prima a tecla W, irá mover-se para Norte.
                ///Caso o jogador prima a tecla S, irá mover-se para Sul.
                ///Caso o jogador prima a tecla A, irá mover-se para Oeste.
                ///Caso o jogador prima a tecla D, irá mover-se para Este.
                ///Caso o jogador prima a tecla E, irá utilizar o item.
                ///Caso o jogador prima a tecla I, irá mostrar o ecrã informativo.
                ///Caso o jogador pirma a tecla Q, irá questionar se pretende 
                ///abadonar o jogo e sair caso a resposta seja afirmativa.
                switch (selectedKey.Key)
                {

                    ///É efectuada uma verificação na grid para obter se a jogada
                    ///que o jogador pretende é valida ou não
                    case ConsoleKey.W:
                        if (grid.playerX > 0)
                        {
                            grid.array[grid.playerX, grid.playerY].Remove(init.player);
                            grid.playerX -= 1;
                            grid.array[grid.playerX, grid.playerY].Add(init.player);
                            playing = false;
                            grid.moved = "NORTH";
                        }

                        ///Caso a verificação falhe, alerta ao jogador que não 
                        ///se pode movimentar para o local pretendido
                        Console.SetCursorPosition(42, 39);
                        Console.WriteLine(" - I can't move on that direction!");
                        break;

                    ///É efectuada uma verificação na grid para obter se a jogada
                    ///que o jogador pretende é valida ou não
                    case ConsoleKey.S:
                        if (grid.playerX < 7)
                        {
                            grid.array[grid.playerX, grid.playerY].Remove(init.player);
                            grid.playerX += 1;
                            grid.array[grid.playerX, grid.playerY].Add(init.player);
                            playing = false;
                            grid.moved = "SOUTH";
                        }

                        ///Caso a verificação falhe, alerta ao jogador que não 
                        ///se pode movimentar para o local pretendido
                        Console.SetCursorPosition(42, 39);
                        Console.WriteLine(" - I can't move on that direction!");
                        break;

                    ///É efectuada uma verificação na grid para obter se a jogada
                    ///que o jogador pretende é valida ou não
                    case ConsoleKey.A:
                        if (grid.playerY > 0)
                        {
                            grid.array[grid.playerX, grid.playerY].Remove(init.player);
                            grid.playerY -= 1;
                            grid.array[grid.playerX, grid.playerY].Add(init.player);
                            playing = false;
                            grid.moved = "WEST";
                        }

                        ///Caso a verificação falhe, alerta ao jogador que não 
                        ///se pode movimentar para o local pretendido
                        Console.SetCursorPosition(42, 39);
                        Console.WriteLine(" - I can't move on that direction!");
                        break;

                    ///É efectuada uma verificação na grid para obter se a jogada
                    ///que o jogador pretende é valida ou não
                    case ConsoleKey.D:
                        if (grid.playerY < 7)
                        {
                            grid.array[grid.playerX, grid.playerY].Remove(init.player);
                            grid.playerY += 1;
                            grid.array[grid.playerX, grid.playerY].Add(init.player);
                            playing = false;
                            grid.moved = "EAST";
                        }

                        ///Caso a verificação falhe, alerta ao jogador que não 
                        ///se pode movimentar para o local pretendido
                        Console.SetCursorPosition(42, 39);
                        Console.WriteLine(" - I can't move on that direction!");
                        break;



                        ///Ao premir a tecla E o jogador consome comida.
                    case ConsoleKey.E:

                        ///Irá verificar se existe algum objecto que seja comida
                        ///no tile qme que o jogador se encontra
                        if (grid.array[grid.playerX, grid.playerY].Contains(init.food1))
                        {
                            ///O jogador recebe vida que a comida fornece
                            init.player.Hp += init.food1.Heal;

                            ///Após consumir a comida, esta desaparece da grid.
                            grid.array[grid.playerX, grid.playerY].Remove(init.food1);

                            ///É iniciado um turno novo.
                            playing = false;
                        }
                        if (grid.array[grid.playerX, grid.playerY].Contains(init.food2))
                        {

                            ///O jogador recebe vida que a comida fornece
                            init.player.Hp += init.food2.Heal;

                            ///Após consumir a comida, esta desaparece da grid
                            grid.array[grid.playerX, grid.playerY].Remove(init.food2);

                            ///É iniciado um turno novo.
                            playing = false;
                        }
                        if (grid.array[grid.playerX, grid.playerY].Contains(init.food3))
                        {

                            ///O jogador recebe vida que a comida fornece
                            init.player.Hp += init.food3.Heal;

                            ///Após consumir a comida, esta desaparece da grid
                            grid.array[grid.playerX, grid.playerY].Remove(init.food3);

                            ///É iniciado um turno novo.
                            playing = false;
                        }

                        ///Ao utilizar a tecla E numa tile que tenha um  objecto 
                        ///que seja um mapa, esta opção revela o nível todo ao
                        ///jogador.
                        if (grid.array[grid.playerX, grid.playerY].Contains(init.map))
                        {

                            ///Verificação das linhas da grid
                            for (int row = 0; row < 8; row++)
                            {

                                ///Verificação das colunas da grid
                                for (int column = 0; column < 8; column++)
                                {

                                    ///Tudo o que se encontra por revelar no mapa,
                                    ///é revelado.
                                    grid.array[row, column].Explored = true;
                                    init.exit.Explored = true;
                                    init.trap1.Explored = true;
                                    init.trap2.Explored = true;
                                    init.trap3.Explored = true;
                                    init.food1.Explored = true;
                                    init.food2.Explored = true;
                                    init.food3.Explored = true;
                                    init.npc.Explored = true;
                                }
                            }

                            ///Após a utilização do mapa, este desaparece da grid.
                            grid.array[grid.playerX, grid.playerY].Remove(init.map);

                            ///É iniciado um turno novo.
                            playing = false;
                        }
                        break;

                        ///Ao premir a tecla I, irá ser mostrado a informação de
                        ///todas as armadilhas que o jogo contêm (nome e dano), 
                        ///esta visualização é efectuada "por cima" da grid de 
                        ///jogo, sendo necessário recolher input do utilizador 
                        ///para continuar a jogar.
                    case ConsoleKey.I:
                        if (grid.playerY < 7)
                        {

                            ///limpa a consola para poder ser mostrado o ecrã
                            ///informativo
                            Console.Clear();
                            Console.SetCursorPosition(0, 1);
                            Console.WriteLine("╔═════════════════════════════════════════════════════" +
                                "══════════════════════════════════════════════════════════════════╗");
                            Console.SetCursorPosition(54, 2);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("[More Info]");
                            Console.ResetColor();
                            Console.SetCursorPosition(48, 9);
                            Console.WriteLine("Recurso's Damage: 0 - 78");
                            Console.SetCursorPosition(49, 12);
                            Console.WriteLine("Spike's Damage: 0 - 22");
                            Console.SetCursorPosition(50, 15);
                            Console.WriteLine("Hole's Damage: 0 - 10");

                            Console.SetCursorPosition(0, 36);
                            Console.WriteLine("╚═════════════════════════════════════════════════════" +
                                "══════════════════════════════════════════════════════════════════╝");
                            Console.SetCursorPosition(127, 1);
                            Console.WriteLine("╔════════════════════════" +
                                "══════════════════════════════════════╗");

                            ///É mostrado a informação actual do jogador, e o 
                            ///nível a que se encontra.
                            Console.SetCursorPosition(140, 2);
                            Console.Write("[Status]");
                            Console.SetCursorPosition(135, 5);
                            Console.Write($"Current Level: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{init.level:000}");
                            Console.ResetColor();
                            Console.SetCursorPosition(135, 8);
                            Console.Write("Player HP: ");

                            ///Irá verificar a vida que o jogador dispões e irá
                            ///alterar a cor da vida consoante a vida que o jogador
                            ///têm. As cores variam entre verde,amarelo e vermelho.
                            if (init.player.Hp > 50)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else if (init.player.Hp <= 50 && init.player.Hp > 20)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            else if (init.player.Hp <= 20 && init.player.Hp > 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else if (init.player.Hp <= 5)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            Console.Write($"{init.player.Hp:000}");
                            Console.ResetColor();

                            ///É mostrado juntamente com a grid do jogo as legendas 
                            ///da grid. 
                            Console.SetCursorPosition(172, 2);
                            Console.Write("[Info]");
                            Console.SetCursorPosition(168, 5);
                            Console.Write("Player - ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\u2302");
                            Console.ResetColor();
                            Console.SetCursorPosition(168, 8);
                            Console.Write("Explored - .");
                            Console.SetCursorPosition(168, 11);
                            Console.Write("Unexplored - ~");
                            Console.SetCursorPosition(168, 14);
                            Console.Write("Exit - ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("E X I T !");
                            Console.ResetColor();
                            Console.SetCursorPosition(168, 17);
                            Console.Write("Trap - ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\u25B2");
                            Console.ResetColor();
                            Console.SetCursorPosition(168, 20);
                            Console.Write("Food - ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\u2665");
                            Console.ResetColor();
                            Console.SetCursorPosition(168, 23);
                            Console.Write("Neutral NPC - ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\u25CA");
                            Console.ResetColor();
                            Console.SetCursorPosition(168, 26);
                            Console.Write("Hostile NPC - ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\u2666");
                            Console.ResetColor();
                            Console.SetCursorPosition(168, 29);
                            Console.Write("Map - ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("\u263C");
                            Console.ResetColor();

                            Console.SetCursorPosition(127, 36);
                            Console.WriteLine("╚════════════════════════" +
                                "══════════════════════════════════════╝");

                            Console.ReadKey();
                            renderer.Render(init, grid);
                            scan.Scan(init, grid);
                        }
                        break;

                        ///Ao premir a tecla Q, irá questionar ao jogador se 
                        ///pretende abandonar o jogo
                    case ConsoleKey.Q:
                        Console.SetCursorPosition(41, 39);
                        Console.WriteLine("Are you sure you want to quit? (Y/N)");
                        while (quitConfirm)
                        {
                            ConsoleKeyInfo quitKey = Console.ReadKey();
                            if (selectedKey.Key != ConsoleKey.Y ||
                                selectedKey.Key != ConsoleKey.N)
                            {
                                Console.SetCursorPosition(41, 39);
                                Console.WriteLine("Are you sure you want to quit? (Y/N)");
                            }
                            else
                            {
                                break;
                            }

                            ///caso o jogador responda de forma válida que prende
                            ///abadonar o jogo irá ser efecutada uma verificação
                            ///se nesse instante consegui bater algum recorde 
                            ///de pontuação na tabela de High Scores do jogo.
                            switch (quitKey.Key)
                            {

                                case ConsoleKey.Y:
                                    Console.SetCursorPosition(42, 41);
                                    Console.Write("Insert your name here: ");
                                    string name = Console.ReadLine();

                                    ///Adiciona o nome e a pontuação actual 
                                    hsm.AddScore(name, init.level);

                                    ///Salva o ficheiro .txt das pontuações
                                    hsm.Save();
                                    MainMenu.Display();
                                    break;
                                case ConsoleKey.N:
                                    quitConfirm = false;
                                    Console.SetCursorPosition(49, 41);
                                    Console.WriteLine("Quiting aborted!");
                                    break;
                            }
                        }
                        break;
                }
            }
        }
    }
}