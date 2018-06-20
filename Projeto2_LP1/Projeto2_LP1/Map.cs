namespace Projeto2_LP1
{

    /// <summary>
    /// Classe que implementa a interface IGameObject, com três propriedas auto-
    /// -implementadas, um constructor e um método override de ToString();.
    /// </summary>
    class Map : IGameObject
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public bool Explored { get; set; }

        /// <summary>
        /// Constructor que permite indicar o símbolo o nome, e se é visível ao 
        /// jogador.
        /// </summary>
        public Map()
        {
            Name = "Map";
            Symbol = "\u263C ";
            Explored = false;
        }

        /// <summary>
        /// Método que através de override permit desenahr na grid o símbolo 
        /// UTF-8 escolhido.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Symbol;
        }
    }
}
