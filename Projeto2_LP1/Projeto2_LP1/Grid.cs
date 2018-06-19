using System;

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

        public int trap1X, trap2X, trap3X = random.Next(0, 8);
        public int trap1Y, trap2Y, trap3Y = random.Next(1, 7);

    //    public int trap2X = random.Next(0, 8);
  //      public int trap2Y = random.Next(1, 7);

       // public int trap3X = random.Next(0, 8);
    //    public int trap3Y = random.Next(1, 7);

        public int foodX = random.Next(0, 8);
        public int foodY = random.Next(1, 7);

        public int npcX = random.Next(0, 8);
        public int npcY = random.Next(1, 7);

        public void CreateGrid(Initializer init)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    array[row, column] = new TileMaker();
                }
            }
            array[playerX, playerY].Add(init.player);
            array[exitX, exitY].Add(init.exit);
            array[trap1X, trap1Y].Add(init.trap1);
            array[trap2X, trap2Y].Add(init.trap2);
            array[trap3X, trap3Y].Add(init.trap3);
            array[foodX, foodY].Add(init.food);
            array[npcX, npcY].Add(init.npc);
        }
    }
}