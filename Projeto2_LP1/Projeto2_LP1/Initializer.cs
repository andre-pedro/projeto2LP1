
namespace Projeto2_LP1
{
    /// <summary>
    /// 
    /// </summary>
    class Initializer
    {
        /// <summary>
        /// Variável de string que indica o nome das traps.
        /// </summary>
        static string porta_fachada, recurso, ice;

        public Player player = new Player();
        public Exit exit = new Exit();
        public Trap trap1 = new Trap(porta_fachada, 21);
        public Trap trap2 = new Trap(recurso, 65);
        public Trap trap3 = new Trap(ice, 5);
        public Food food = new Food();
        public NPC npc = new NPC();

        public int level = 1;

        public void Init()
        {

        }
    }
}
