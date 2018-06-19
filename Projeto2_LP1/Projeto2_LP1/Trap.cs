
namespace Projeto2_LP1
{
    /// <summary>
    /// Esta classe herda da interface IGameObject. É composta por três 
    /// propriedades, um constructor e um método override "ToString()". 
    /// </summary>
    class Trap : IGameObject
    {
        /// <summary>
        /// Nestas três propriedades auto-implementadas, é nos permitido indicar
        /// e obter o nome, o símbolo da armadilha e o  dano causado ao jogador
        /// caso, este acione a armadilha.
        /// </summary>
        public string Name { get; set; }
        public string Symbol { get; set; }
        public float Damage { get; set; }

        /// <summary>
        /// O Constructor Trap indica o nome da armadilha, o símbolo que foi 
        /// dado através da codificação UTF-8 e a quantidade de dano que o 
        /// jogador poderá perder quando se deparar com ela.
        /// </summary>
        /// <param name="name">O nome dado a armadilha na altura da criação da 
        /// mesma no nosso código</param>
        /// <param name="damage">Dano que o jogador irá receber caso "se encontre"
        /// com uma armadilha</param>
        public Trap(string name, int damage)
        {
            Name = name;
            Symbol = "\u25B2 ";
            Damage = damage;
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
