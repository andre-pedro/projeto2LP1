using System;

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
            Renderer render = new Renderer();
            Renderer.Render();

            // Instanciar Player
            Player player = new Player();
            // Instanciar NPC
            NPC npc = new NPC();

            // Tester metodos das classes PLayer e NPC
            Console.WriteLine("Player Direction: " + player.Move());
            Console.WriteLine("NPC Direction: " + npc.Move());
        }
    }
}
