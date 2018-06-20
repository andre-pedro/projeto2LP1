namespace Projeto2_LP1
{
    class Player : IGameObject
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public float Hp { get; set; }
        public float Ap { get; set; }

        public Player()
        {
            Name = "Player";
            Symbol = "\u2302 ";
            Hp = 100;
            Ap = 10;
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}