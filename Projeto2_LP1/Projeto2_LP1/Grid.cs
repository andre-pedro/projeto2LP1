using System;
using System.Collections.Generic;

namespace Projeto2_LP1
{
    class Grid
    {

        public Grid()
        {

            String[,] simbolos = new string[8, 8];

            for (int linha = 0; linha < 8; linha++)
            {
                for (int coluna = 0; coluna < 8; coluna++)
                {
                    List<IObject> objectos = new List<IObject>();
                    for (int i = 0; i < 10; i++)
                        objectos.Add(null as IObject);
                }
            }

        }
    }
}
