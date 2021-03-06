﻿namespace Projeto2_LP1
{
    /// <summary>
    /// Esta classe implementa da interface IgameObject. É composta por quatro 
    /// propriedades, todas elas de com a possibilidade de escrita e leitura. 
    /// Possui também um constructor e um método override "ToString()".
    /// </summary>
    class Food : IGameObject
    {

        /// <summary>
        /// Nestas quatro propriedades auto-implementadas conseguimos indicar e 
        /// obter o nome, o simbolo e a quantidade de HP que o jogador consegue
        /// recuperar. Existe ainda uma classe booleana que permite indicar se 
        /// o objecto do tipo food se encontra visível pelo jogador.
        /// </summary>
        public string Name { get; set; }
        public string Symbol { get; set; }
        public float Heal { get; set; }
        public bool Explored { get; set; }


        /// <summary>
        /// O Constructor Food indica o nome da comida, o símbolo que foi escolhido
        /// em UTF-8, a quantidade de vida que o jogador pode recuperar e se já
        /// se encontra visível por parte do jogador..
        /// </summary>
        /// <param name="name">O nome dado a cada tipo de comida na criação da 
        /// mesma, pois cada tipo de comida irá fornecer ao jogador um hp 
        /// recuperável diferente.</param>
        /// <param name="heal">A vida que o jogador irá recuperar caso 
        /// apanhe com um certo tipo de comida.</param>
        public Food(string name, int heal)
        {
            Name = name;
            Symbol = "\u2665 ";
            Heal = heal;
            Explored = false;
        }


        /// <summary>
        /// Através do override é possivel modificar o método ToString para 
        /// devolver o símbolo escolhido para a grid de visualização.
        /// </summary>
        /// <returns>Símbolo em UTF-8</returns>
        public override string ToString()
        {
             return Symbol;

        }
    }
}