﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Trap : IGameObject
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public bool Explored { get; set; }
        public Trap(string name, int damage)
        {
            Name = name;
            Symbol = "T";
            Explored = false;
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
