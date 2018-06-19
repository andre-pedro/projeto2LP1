
namespace Projeto2_LP1
{
    class Trap : IGameObject
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public float Damage { get; set; }

        public Trap(string name, int damage)
        {
            Name = name;
            Symbol = "\u25B2 ";
            Damage = damage;
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
