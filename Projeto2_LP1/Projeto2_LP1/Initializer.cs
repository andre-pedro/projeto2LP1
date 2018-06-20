using System;

namespace Projeto2_LP1
{
    /// <summary>
    /// 
    /// </summary>
    class Initializer
    {
        static Random random = new Random();

        public Player player = new Player();
        public Exit exit = new Exit();
        public Trap trap1 = new Trap("a recurso", random.Next(0, 78));
        public Trap trap2 = new Trap("a spike", random.Next(0, 22));
        public Trap trap3 = new Trap("a hole", random.Next(0, 10));
        public Food food1 = new Food("an orange", 18);
        public Food food2 = new Food("a loaf of bread", 35);
        public Food food3 = new Food("a banana", 22);
        public NPC npc = new NPC();
        public Map map = new Map();

        public int level = 1;

        public void Init()
        {

        }
    }
}
