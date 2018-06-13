
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
            Renderer rend = new Renderer();
            Grid grid = new Grid();

           // State[,] teste = new State[8, 8];

            Renderer.Render(grid);
        }
    }
}
