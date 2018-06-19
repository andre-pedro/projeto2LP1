using System;

namespace Projeto2_LP1
{
    public class NPC : IGameObject
    {

        public string Name { get; set; }
        public string Symbol { get; set; }
        public string SymbolNeutral { get; set; }
        public string SymbolHostile { get; set; }
        public float Hp { get; set; }
        public float Ap { get; set; }
        public bool Neutral { get; set; }

        public NPC()
        {
            Random random = new Random();

            int value = random.Next(0, 2);
            if (value == 0)
            {
                Name = "Neutral NPC";
                Symbol = "\u25CA ";
                Neutral = true;
            }
            else
            {
                Name = "Hostile NPC";
                Symbol = "\u2666 ";
                Neutral = false;
            }
            Hp = 20;
            Ap = 3;
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
