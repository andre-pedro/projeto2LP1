using System;

namespace Projeto2_LP1
{
    class Renderer
    {
        public static void Render()
        {
            Grid grid = new Grid();

            //  String[,] simbolos = new string[8, 8];
            //  String[,][] simbolos = new string[8, 8][];
            // List<T>[,];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        Console.Write(".");

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
