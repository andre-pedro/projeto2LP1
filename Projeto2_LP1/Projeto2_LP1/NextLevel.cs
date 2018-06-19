using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class NextLevel
    {
        public bool HasLeveled(Initializer init, Grid grid)
        {
            if (grid.array[grid.playerX, grid.playerY].Contains(init.player) &&
                grid.array[grid.playerX, grid.playerY].Contains(init.exit) && init.player.Hp > 0)
            {
                init.level++;
                return true;
            }
            return false;
        }
    }
}
