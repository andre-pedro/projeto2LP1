using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Renderer rend = new Renderer(720, 640);

            //State[,] teste = new State[8, 8];

            //Renderer.Render(teste);

            string[,] row = new string[8, 8];
            string finalvalofcolumn = string.Empty;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    row[i, j] = "-------- ";
                    row[i, j] = "-------- ";

                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(row[i, j], " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();

        }

    }
}
