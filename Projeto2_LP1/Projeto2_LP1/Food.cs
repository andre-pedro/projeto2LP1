using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Food : IGameObject
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public float Heal { get; set; }

        public Food()
        {
            Name = "Cat food";
            Symbol = "\u2665 ";
            Heal = 25;
        public override string ToString()
        {
            return Symbol;
        }
    }
}