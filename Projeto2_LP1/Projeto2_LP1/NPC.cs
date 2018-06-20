using System;

namespace Projeto2_LP1
{

    /// <summary>
    /// Classe que NPC que implementa a interface IgameObject e 
    /// </summary>
    public class NPC : IGameObject
    {
        /// <summary>
        /// Proprieda que indica o nome do NPC
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Proprieda que indica o símbolo do NPC
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Propriedade que indica qual é o símbolo do npc neutro
        /// </summary>
        public string SymbolNeutral { get; set; }

        /// <summary>
        /// Propriedade que indica qual é o símbolo do npc Hostíl
        /// </summary>
        public string SymbolHostile { get; set; }

        /// <summary>
        /// Propriedade que indica a vida dos NPCs
        /// </summary>
        public float Hp { get; set; }
        public float Ap { get; set; }
        public bool Neutral { get; set; }

        /// <summary>
        /// Propriedade que indica através de um booleano se os npcs se encontram
        /// visíveis ou não
        /// </summary>
        public bool Explored { get; set; }

        public NPC()
        {

            ///Instância da classe random que permite criar um número variaveis
            ///de npcs.
            Random random = new Random();

            ///random que indica o número de npcs.
            int chosenNpc = random.Next(0, 2);
            if (chosenNpc == 0)
            {
                Name = "Neutral NPC";
                Symbol = "\u25CA ";
                Neutral = true;
            }
            else
            {
                Name = "Hostile NPC";
                Symbol = "\u2666 ";
                Neutral = false;
            }
            Hp = 100;
            Ap = 3;
            Explored = false;
        }

        /// <summary>
        /// Método override que permite desenhar o npc na grid de jogo.
        /// </summary>
        /// <returns>Retorna o símbolo UTF-8 para para a grid de jogo, fazendo 
        /// seja visível quando o jogador estiver perto. </returns>
        public override string ToString()
        {
            return Symbol;
        }
    }
}
