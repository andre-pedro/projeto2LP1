using System;

namespace Projeto2_LP1
{
    /// <summary>
    /// Esta classe permite utilizar de uma forma mais simples, os objectos 
    /// criados para o jogo. Através do método que contém é possível criar e 
    /// utilizar estes objectos sem ser necessário instanciar 
    /// </summary>
    class Initializer
    {
        /// <summary>
        /// Inicializa uma nova instânica da class Random que nos permite
        /// indicar entre zero e o valor máximo de dano que cada armadilha pode
        /// retirar ao jogador.
        /// </summary>
        static Random random = new Random();

        /// <summary>
        /// Inicializa uma nova instânica da class player.
        /// </summary>
        public Player player = new Player();

        /// <summary>
        /// Inicializa uma nova instânica da class Exit.
        /// </summary>
        public Exit exit = new Exit();

        /// <summary>
        /// Inicializa uma nova instânica da class Trap.Visto que para a criação
        /// de uma trap é necessário efectuar uma passagem de dois parâmetros, é
        /// indicado aqui qual o nome da armadilha e o máximo de dano que pode
        /// tirar ao jogador.
        /// </summary>
        public Trap trap1 = new Trap("a recurso", random.Next(0, 78));
        public Trap trap2 = new Trap("a spike", random.Next(0, 60));
        public Trap trap3 = new Trap("a hole", random.Next(0, 50));

        /// <summary>
        /// Inicializa uma nova instânica da class Food. É efectuado a criação
        /// de três tipos de comida diferentes. Com a pasagem de dois parâmetros
        /// permite indicar que tipo de comida é e quanto hp o jogador irá 
        /// regenerar ao utilizar cada tipo de comida.
        /// </summary>
        public Food food1 = new Food("an orange", 8);
        public Food food2 = new Food("a loaf of bread", 12);
        public Food food3 = new Food("a banana", 10);
        public NPC npc = new NPC();
        public Map map = new Map();

        /// <summary>
        /// Variável que indica o nível em que o jogador se encontra, 
        /// inicializada a 1.
        /// </summary>
        public int level = 1;

        /// <summary>
        /// Método que permite utilizar as instânicas anteriormente criadas.
        /// </summary>
        public void Init()
        {

        }
    }
}
