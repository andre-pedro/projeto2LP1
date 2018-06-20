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
        /// armadilhas em qualquer espaço do mapa, foi efectuado uma posição
        /// aleatória tanto no X como no Y das armadilhas. 
        /// </summary>
        public int trap1X = random.Next(0, 8);
        public int trap1Y = random.Next(0, 8);

        public int trap2X = random.Next(0, 8);
        public int trap2Y = random.Next(0, 8);

        public int trap3X = random.Next(0, 8);
        public int trap3Y = random.Next(0, 8);

        /// <summary>
        /// Criação de X e Y para a comida, visto que se pode encontrar em 
        /// qualquer lado do mapa, foi efectuado a posição de cada uma com X e 
        /// Y aleatórios.
        /// </summary>
        public int food1X = random.Next(0, 8);
        public int food1Y = random.Next(0, 8);

        public int food2X = random.Next(0, 8);
        public int food2Y = random.Next(0, 8);

        public int food3X = random.Next(0, 8);
        public int food3Y = random.Next(0, 8);

        public int npcX = random.Next(0, 8);
        public int npcY = random.Next(0, 8);

        public int mapX = random.Next(0, 8);
        public int mapY = random.Next(0, 8);

        public string moved = "NONE";

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
            array[food1X, food1Y].Add(init.food1);
            array[food2X, food2Y].Add(init.food2);
            array[food3X, food3Y].Add(init.food3);
            array[npcX, npcY].Add(init.npc);
            array[mapX, mapY].Add(init.map);
        }
    }
}