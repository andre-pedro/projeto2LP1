using System;


namespace Projeto2_LP1
{
    class Renderer
    {
        private readonly int Width;
        private readonly int Height;

        public Renderer(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public void Render(State array)
        {
            State[,] teste = new State[8, 8];
            foreach (State t in teste)
            {
                Console.WriteLine("-");
            }
        }
    }
}
