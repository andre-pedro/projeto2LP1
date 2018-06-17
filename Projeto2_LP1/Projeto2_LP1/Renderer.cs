using System;
using System.Collections.Generic;

namespace Projeto2_LP1
{
    class Renderer
    {
        public static IEnumerable<Grid> simbolos { get; private set; }

        public static void Render()
        {
            Grid grid = new Grid();
            Tiles simbol = new Tiles();

            //  String[,] simbolos = new string[8, 8];
            //  String[,][] simbolos = new string[8, 8][];
            // List<T>[,];

            /*
            //este funciona sem simbolos
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                       // Console.Write(".");
                        Console.Write(simbol);
                    }
                    Console.Write("\t");

                }
                Console.WriteLine();
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                       // Console.WriteLine("\t");
                        Console.Write(".");

                    }
                    Console.Write("\t");
                    
                    //  Console.Write("\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            //done here, thest bottom.
            */

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //neste foreach e preciso passar os objectos para aqui
                    //como, ainda nao sei =/
                    foreach(Grid sim in simbolos)
                    {
                        Console.Write(sim);
                    }
                    Console.Write("\t");

                }
                Console.WriteLine();
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        // Console.WriteLine("\t");
                        Console.Write(".");

                    }
                    Console.Write("\t");

                    //  Console.Write("\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }



        }
    }
}
