using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Grid
    {
        static Random random = new Random();

        public TileMaker[,] array = new TileMaker[8, 8];

        public int playerX = random.Next(0, 8);
        public int playerY = 0;
    }
}