using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Map : IGameObject
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public bool Explored { get; set; }

        public Map()
        {
            Name = "Map";
            Symbol = "M ";
            Explored = false;
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
