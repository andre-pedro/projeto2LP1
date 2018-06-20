namespace Projeto2_LP1
{

    /// <summary>
    /// Esta classe implementa da interface IgameObject. É composta por quatro 
    /// propriedades, todas elas de com a possibilidade de escrita e leitura. 
    /// Possui também um constructor e um método override "ToString()"
    /// </summary>
    class Player : IGameObject
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public float Hp { get; set; }
        public float Ap { get; set; }

        /// <summary>
        /// Constructor que indica a vida, o dano inicial assim como o nome e o
        /// símbolo utilizado na visualização da grid.
        /// </summary>
        public Player()
        {
            Name = "Player";
            Symbol = "\u2302 ";
            Hp = 100;
            Ap = 10;
        }

        /// <summary>
        /// Através do override é possivel modificar o método ToString para 
        /// devolver o símbolo escolhido para a grid de visualização.
        /// </summary>
        /// <returns>Símbolo em UTF-8</returns>
        public override string ToString()
        {
            return Symbol;
        }
    }
}