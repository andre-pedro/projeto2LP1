using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    public class Player : Character
    {
        public override char Move()
        {
            // Variavel que guarda input
            string input = "";
            // Variavel que guarda direcao
            char direction = ' ';

            // Pedir input de direcao
            Console.Write("In which direction are you heading?" + "\t" + "- ");
            // Guardar input de direcao
            input = Console.ReadLine();

            // Escolher direcao a partir do input do jogador
            switch (input.ToLower())
            {
                // Se "W" ou "w"
                // Norte
                case "w":
                    direction = 'N';
                    break;
                // Se "S" ou "s"
                // Sul
                case "s":
                    direction = 'S';
                    break;
                // Se "A" ou "a"
                // Oeste
                case "a":
                    direction = 'W';
                    break;
                // Se "D" ou "d"
                // Este
                case "d":
                    direction = 'E';
                    break;
            }

            // Retorna direcao
            return direction;
        }
    }
}
