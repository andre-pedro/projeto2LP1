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
                // Verificacao trap1
                if (grid.array[grid.playerX, grid.playerY].Contains(init.trap1) &&
                    init.trap1.FallenInto == false)
                {
                    init.player.Hp -= init.trap1.Damage;
                    init.trap1.FallenInto = true;
                }
                // Verificacao trap2
                if (grid.array[grid.playerX, grid.playerY].Contains(init.trap2) &&
                    init.trap2.FallenInto == false)
                {
                    init.player.Hp -= init.trap2.Damage;
                    init.trap2.FallenInto = true;
                }
                // Verificacao trap3
                if (grid.array[grid.playerX, grid.playerY].Contains(init.trap3) &&
                    init.trap3.FallenInto == false)
                {
                    init.player.Hp -= init.trap3.Damage;
                    init.trap3.FallenInto = true;
                }
                renderer.Render(init, grid);
                scan.Scan(init, grid);
                controls.CheckInputs(init, grid);
                init.player.Hp--;
                if (init.player.Hp > 100)
                {
                    init.player.Hp = 100;
                }
                Console.Clear();
                if (hasLeveled.HasLeveled(init, grid) == true)
                {
                    grid = new Grid();
                    grid.CreateGrid(init);
                    renderer.Render(init, grid);
                }
            }
            hasDied.Die(init);
        }
    }
}
