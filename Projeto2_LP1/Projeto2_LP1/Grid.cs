using System;

namespace Projeto2_LP1
{

    /// <summary>
    /// Esta classe é a estrutura de dados central e fundamental para o jogo 
    /// como um todo. Contém um array de TileMaker multidimensional 8x8 que 
    /// representa a grid onde o jogador joga. 
    /// </summary>
    class Grid
    {

        /// <summary>
        ///Inicializa uma nova instânica da class Random que nos permite posicionar
        ///os objectos que o jogo contêm de forma aleatória no nosso mapa de jogo.
        /// </summary>
        static Random random = new Random();

        /// <summary>
        /// Criação de um array do tipo TileMaker 8x8 para inserir os objectos
        /// que o jogador possa interagir, tal como comida, armadilhas, etc..
        /// </summary>
        public TileMaker[,] array = new TileMaker[8, 8];

        public Initializer level = new Initializer();

        /// <summary>
        /// Criação do X e Y do jogador. O X é posicionado aleatoriamente entre
        /// a linha 0 e 7 do array enquanto o Y do jogador é 0, devido ao jogo
        /// iniciar com o jogador na coluna 0.
        /// </summary>
        public int playerX = random.Next(0, 8);
        public int playerY = 0;

        /// <summary>
        /// Criação do X e Y da saída. O X é posicionado na última coluna mas 
        /// numa linha aleatória dessa coluna.
        /// </summary>
        public int exitX = random.Next(0, 8);
        public int exitY = 7;

        /// <summary>
        /// Criação de X e Y para as armadilhas, visto que se pode encontrar 
        /// armadilhas em qualquer parte do mapa, foi efectuado uma posição X e
        /// Y de forma aleatória.
        /// </summary>
        public int trap1X = random.Next(0, 8);
        public int trap1Y = random.Next(0, 8);

        public int trap3X = random.Next(0, 8);
        public int trap3Y = random.Next(0, 8);

        /// <summary>
        /// Criação de X e Y para a comida. Foi criado a posição X e Y 
        /// aleatórios para se poder encontrar em qualquer parte do mapa. 
        /// </summary>
        public int food1X = random.Next(0, 8);
        public int food1Y = random.Next(0, 8);

        public int food2X = random.Next(0, 8);
        public int food2Y = random.Next(0, 8);

        public int food3X = random.Next(0, 8);
        public int food3Y = random.Next(0, 8);

        /// <summary>
        /// Criação de X e Y para os npcs. Foi criado a posição X e Y 
        /// aleatórios para se poder encontrar em qualquer parte do mapa. 
        /// </summary>
        public int npcX = random.Next(0, 8);
        public int npcY = random.Next(0, 8);

        /// <summary>
        /// Criação de X e Y para o mapa que revela todo o nível. Foi criado 
        /// a posição X e Y  aleatórios para se poder encontrar em qualquer 
        /// parte .
        /// </summary>
        public int mapX = random.Next(0, 8);
        public int mapY = random.Next(0, 8);

        /// <summary>
        /// Criação de uma variável que indica se existe movimento, foi criada 
        /// nesta class devido a class Grid ser a base em termos de estrutura 
        /// para todo o projecto.
        /// </summary>
        public string moved = "NONE";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="init"></param>
        public void CreateGrid(Initializer init)
        {
            ///pecorre cada linha da nossa grid.
            for (int row = 0; row < 8; row++)
            {
                ///pecorre cada coluna da nossa grid.
                for (int column = 0; column < 8; column++)
                {
                    ///adiciona ano nosso array multidimensional na posição X e
                    ///Y um TileMarker.
                    array[row, column] = new TileMaker();
                }
            }
            array[playerX, playerY].Add(init.player);
            array[exitX, exitY].Add(init.exit);

            ///Por cada nível que o jogador ultrapassa, a dificuldade aumenta 
            ///existindo mais armadilhas.
            for (int i = 0; i < init.level; i++)
            {

                /// <summary>
                /// Criação de X e Y para as armadilhas, visto que se pode encontrar 
                /// armadilhas em qualquer parte do mapa, foi efectuado uma posição X e
                /// Y de forma aleatória.
                /// </summary>

                int trap1X = random.Next(0, 8);
                int trap2X = random.Next(0, 8);
                int trap3X = random.Next(0, 8);
                int trap1Y = random.Next(0, 8);
                int trap2Y = random.Next(0, 8);
                int trap3Y = random.Next(0, 8);

                array[trap1X, trap1Y].Add(init.trap1);
                array[trap2X, trap2Y].Add(init.trap2);
                array[trap3X, trap3Y].Add(init.trap3);
            }
            array[food1X, food1Y].Add(init.food1);
            array[food2X, food2Y].Add(init.food2);
            array[food3X, food3Y].Add(init.food3);
            array[npcX, npcY].Add(init.npc);
            array[mapX, mapY].Add(init.map);
        }
    }
}