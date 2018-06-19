using System;
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
        public float Damage { get; set; }
    }

    public Trap()
    {
        Name = "Recurso";
        Symbol = "\u25B2 ";
        Damage = 78;
    }
}
