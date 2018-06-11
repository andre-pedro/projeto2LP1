

namespace Projeto2_LP1
{
    class Grid
    {
        private State [,] grid;

        public Grid() {

           grid = new State[8, 8];
        }

        public State GetState(Position position)
        {
            return grid[position.Linha, position.Coluna];
        }
    }
}
