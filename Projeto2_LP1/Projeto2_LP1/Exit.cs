
namespace Projeto2_LP1
{
    class Exit : IGameObject
    {
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