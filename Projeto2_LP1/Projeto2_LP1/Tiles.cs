using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Tiles : List<IObject>
    {
        List<string> simbolos = new List<string>();

        public void Adiciona()
        {
            simbolos.Add(".");
            simbolos.Add("~");
            simbolos.Add("~");

           // yield return simbolos[0];
       //     yield return simbolos[1];
         //   yield return simbolos[2];
        }
        // for (if list space has nothing, add .)
        // 

        public override string ToString()
        {
            return $"{simbolos[0] }";
        }

        //se o mapa for visivel 
        //pecorre a lista e por cada elemento imprimi
        //se for uma trap imprimi T
        // se for x imprimi y...

    }
}
