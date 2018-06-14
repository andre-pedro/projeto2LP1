using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    public abstract class Obj
    {
        // Propriedade
        public string Name { get; }

        // Methodo que escolhe posicao
        public abstract char SpawnExit();
    }
}
