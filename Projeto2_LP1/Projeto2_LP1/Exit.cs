using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Exit : IGameObject
    {
        public string Name { get; set; }
        public string Symbol { get; set; }

        public Exit()
        {
            Name = "the exit";
            Symbol = "E X I T ! ";
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}