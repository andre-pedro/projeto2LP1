using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    public abstract class Character
    {
        // Propriedade
        public string Name { get; }

        // Methodo que escolhe direcao
        public abstract char Move();
    }
}
