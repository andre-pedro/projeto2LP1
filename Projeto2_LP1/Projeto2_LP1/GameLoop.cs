using System;
using System.Text;


namespace Projeto2_LP1
{

    /// <summary>
    /// Classe responsável por efectuar  o ciclo do jogo.
    /// </summary>
    class GameLoop
    {

        /// <summary>
        /// É criada uma instânica desta classe para que seja possível efectuar
        /// constantes verificações a alterações na grid.
        /// </summary>
        Grid grid = new Grid();

        /// <summary>
        /// É criada uma instância desta classe para poder ser visualizado toda 
        /// a informação durante o decorrer do jogo. Grid, movimentos, informação
        /// do jogador, legendas, etc..
        /// </summary>
        Renderer renderer = new Renderer();

        /// <summary>
        /// É criada uma instância da classe Surroundings, pois é necessário efectuar
        /// uma constante verificação em cadaturno do que o jogador consegue 
        /// visualizar a sua volta.
        /// /// </summary>
        Surroundings scan = new Surroundings();
        
        /// <summary>
        /// É criada uma instânica da classe Controls para permitir ao jogador 
        /// selecionar o input desejado. 
        /// </summary>
        Controls controls = new Controls();

        /// <summary>
        /// É criada uma instância da classe NextLevel para efecutar uma verificação
        /// e passar de nível caso seja efectuada com sucesso.
        /// </summary>
        NextLevel hasLeveled = new NextLevel();

        /// <summary>
        /// É criada uma instância da classe GameOver para efectuar uma verificação
        /// constante se o jogador morreu. Caso seja afirmativa mostra o ecrã 
        /// de Game Over.
        /// </summary>
        GameOver hasDied = new GameOver();


        /// <summary>
        /// Método que inicia um novo jogo, ao premir "New Game" no ecrã Main menu.
        /// </summary>
        /// <param name="init"></param>
        public void NewGame(Initializer init)
        {

            ///Permite a utilização de caracteres UTF8 na consola.
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            grid.CreateGrid(init);

            ///Ciclo de jogo que irá ser efectuado, enquanto a vida do jogador 
            ///seja superior a 0.
            while (init.player.Hp > 0)
            {
                ///Efectuada uma verificação na tile em que o jogador se encontra
                ///para poder obter os objectos do tipo Trap e agir em conformidade.


                ///Verificação de objectos do tipo Trap1
                if (grid.array[grid.playerX, grid.playerY].Contains(init.trap1) &&
                    init.trap1.FallenInto == false)
                {

                    ///O jogador perde vida igual ao dano que a armadilha possui.
                    init.player.Hp -= init.trap1.Damage;

                    ///O booleano passa a true, o jogador já não poderá levar 
                    ///dano da mesma armadilha caso passe ou permaneça no mesmo
                    ///tile em turnos diferentes.
                    init.trap1.FallenInto = true;
                }

                ///Verificação de objectos do tipo Trap2
                if (grid.array[grid.playerX, grid.playerY].Contains(init.trap2) &&
                    init.trap2.FallenInto == false)
                {

                    ///O jogador perde vida igual ao dano que a armadilha possui.
                    init.player.Hp -= init.trap2.Damage;

                    ///O booleano passa a true, o jogador já não poderá levar 
                    ///dano da mesma armadilha caso passe ou permaneça no mesmo
                    ///tile em turnos diferentes.
                    init.trap2.FallenInto = true;
                }

                ///Verificação de objectos do tipo Trap3
                if (grid.array[grid.playerX, grid.playerY].Contains(init.trap3) &&
                    init.trap3.FallenInto == false)
                {

                    ///O jogador perde vida igual ao dano que a armadilha possui.
                    init.player.Hp -= init.trap3.Damage;

                    ///O booleano passa a true, o jogador já não poderá levar 
                    ///dano da mesma armadilha caso passe ou permaneça no mesmo
                    ///tile em turnos diferentes.
                    init.trap3.FallenInto = true;
                }
                renderer.Render(init, grid);
                scan.Scan(init, grid);
                controls.CheckInputs(init, grid);
                init.player.Hp--;

                ///É efectuada uma verificação para que caso a vida do jogador 
                ///esteja a 100, este não pode ultrapassar este número, mesmo que 
                ///utiliza uma comida.
                if (init.player.Hp > 100)
                {
                    init.player.Hp = 100;
                }
                Console.Clear();

                ///Verifica se houve passagem de nível, caso seja positivo gera
                ///um novo nível de forma procedimental.
                if (hasLeveled.HasLeveled(init, grid) == true)
                {
                    grid = new Grid();
                    grid.CreateGrid(init);
                    renderer.Render(init, grid);
                }
            }

            ///Jogador tem vida inferior a 0, logo é mostrado o ecrã de Game
            ///Over.
            hasDied.Die(init);
        }
    }
}
