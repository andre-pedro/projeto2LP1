using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class GameLoop
    {
        Grid grid = new Grid();
        Renderer renderer = new Renderer();
        Surroundings scan = new Surroundings();
        Controls controls = new Controls();
        NextLevel hasLeveled = new NextLevel();
        GameOver hasDied = new GameOver();

        public void NewGame(Initializer init)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            grid.CreateGrid(init);
            bool gameOver = false;
            while (gameOver == false)
            {
                renderer.Render(init, grid);
                scan.Scan(init, grid);
                controls.CheckInputs(init, grid);
                init.player.Hp--;
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
                if (init.player.Hp > 100)
                {
                    init.player.Hp = 100;
                }
                if (init.player.Hp <= 0)
                {
                    gameOver = true;
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
