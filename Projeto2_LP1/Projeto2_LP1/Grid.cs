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

        public int exitX = random.Next(0, 8);
        public int exitY = 7;

        public int trap1X = random.Next(0, 8);
        public int trap1Y = random.Next(1, 7);

        public int trap2X = random.Next(0, 8);
        public int trap2Y = random.Next(1, 7);

        public int trap3X = random.Next(0, 8);
        public int trap3Y = random.Next(1, 7);

        public int npcX = random.Next(0, 8);
        public int npcY = random.Next(1, 7);
    }
}