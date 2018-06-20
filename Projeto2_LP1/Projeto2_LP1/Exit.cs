
namespace Projeto2_LP1
{

    /// <summary>
    /// Esta classe herda da interface IGameObject. É composta por três 
    /// propriedades, um construcotr e um método override ToString();.
    /// </summary>
    class Exit : IGameObject
    {

        /// <summary>
        /// Nestas três propriedades auto-implementadas, conseguimos indicar e 
        /// obter a seguinte informação:
        /// O nome e símbolo que o jogador irá visualizar quando se deparar 
        /// com a saída do nível, ou seja,o  nome aparece nas mensagens indicadas
        /// ao jogador assim como o símbolo indica ao jogador aonde se encontra a
        /// saída. Já a propriedade booleana Explored indica se a saída já foi 
        /// explorada pelo jogador ou revelação através do mapa.
        /// </summary>
        public string Name { get; set; }
        public string Symbol { get; set; }
        public bool Explored { get; set; }

        public Exit()
        {
            Name = "the exit";
            Symbol = "E X I T ! ";
            Explored = false;
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}