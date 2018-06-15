using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Tiles
    {
        List<string> simbolos = new List<string>();

        public string Adiciona()
        {
            simbolos.Add("t");
            simbolos.Add(".");
            simbolos.Add("~");

            return simbolos[0];
        }
        // for (if list space has nothing, add .)
        // 

      /*  private static  char Simbolos(Grid grid)
        {
            switch (grid)
            {
                case Grid.sim:
                    return 'R';

                default:
                    return '.';
            }
        }*/
    }
}
