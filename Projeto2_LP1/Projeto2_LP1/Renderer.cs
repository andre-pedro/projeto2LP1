using System;


namespace Projeto2_LP1
{
    class Renderer
    {
     // private readonly int Width;
      //private readonly int Height;

      /*public Renderer(int width, int height)
        {
          this.Width = width;
          this.Height = height;
        }*/

          

        public static void Render(Grid grid)
        {
            State[,] array = new State[8, 8];

            foreach(State s in array)
            {

            }

            int linhafinal = array.GetLength(0);
            int colinafinal = array.GetLength(1);

            for (int linha = 0; linha < 8; linha++)
            {
          
                Console.WriteLine($"{array[linha,0]}");
                for (int coluna = 0; coluna < 8; coluna++)
                {
       
                }
                
            }
            
        }
    }
}
