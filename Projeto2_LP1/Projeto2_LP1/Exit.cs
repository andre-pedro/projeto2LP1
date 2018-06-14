using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    public class Exit : Obj
    {
        // Substituicao do metodo Move()
        public override char SpawnExit()
        {
            // Instancia random
            Random rand = new Random();
            // Variavel que guarda posicao
            char position = ' ';

            // Escolher posicao na grid a partir de random (entre 1 e 65)
            switch (rand.Next(1, 65))
            {
                // Caso random seja 1
                case 1:
                    position = ' ';
                    break;
            }

            // Retorna direcao
            return position;
        }
    }
}
