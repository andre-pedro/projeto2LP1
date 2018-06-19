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


    }
}
}
