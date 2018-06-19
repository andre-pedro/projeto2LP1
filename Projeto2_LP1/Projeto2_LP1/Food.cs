

namespace Projeto2_LP1
{
    /// <summary>
    /// Esta classe herda da interface IgameObject. É composta por três 
    /// propriedades, todas elas de com a possibilidade de escrita e leitura. 
    /// Possui também um constructor e um método override "ToString()".
    /// </summary>
    class Food : IGameObject
    {

        /// <summary>
        /// Nestas três propriedades auto-implementadas conseguimos indicar e 
        /// obter o nome, o simbolo e a quantidade de HP que o jogador consegue
        /// recuperar
        /// </summary>
        public string Name { get; set; }
        public string Symbol { get; set; }
        public float Heal { get; set; }


        /// <summary>
        /// O Constructor Food indica o nome da comida, o símbolo que foi escolhido
        /// em UTF-8 e a quantidade de vida que o jogador pode recuperar.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="heal"></param>
        public Food(string name, int heal)
        {
            Name = name;
            Symbol = "\u2665 ";
            Heal = heal;
        }


        /// <summary>
        /// Através do override é possivel modificar o método ToString para 
        /// devolver o símbolo escolhido para a grid de visualização.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Symbol;
        }
    }
}