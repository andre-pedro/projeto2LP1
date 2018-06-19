
namespace Projeto2_LP1
{
    /// <summary>
    /// 
    /// </summary>
    class Initializer
    {
        public Player player = new Player();
        public Exit exit = new Exit();
        public Trap trap1 = new Trap("recurso", 50);
        public Trap trap2 = new Trap("spike", 10);
        public Trap trap3 = new Trap("hole", 15);
        public Food food1 = new Food("orange", 10);
        public Food food2 = new Food("bread", 25);
        public Food food3 = new Food("banana", 15);
        public NPC npc = new NPC();

        public int level = 1;

        public void Init()
        {

        }
    }
}
