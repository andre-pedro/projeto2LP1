using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    public class NPC : Character
    {
        // Substituicao do metodo Move()
        public override char Move()
        {
            // Instancia random
            Random rand = new Random();
            // Variavel que guarda direcao
            char direction = ' ';

            // Escolher diracao a partir de random (entre 1 e 5)
            switch (rand.Next(1, 5))
            {
                // Caso random seja 1
                case 1:
                    // Norte
                    direction = 'N';
                    break;
                // Caso random seja 2
                case 2:
                    // Sul
                    direction = 'S';
                    break;
                // Caso random seja 3
                case 3:
                    // Este
                    direction = 'E';
                    break;
                // Caso random seja 4
                case 4:
                    // Oeste
                    direction = 'W';
                    break;
            }

            // Retorna direcao
            return direction;
        }
    }
}
