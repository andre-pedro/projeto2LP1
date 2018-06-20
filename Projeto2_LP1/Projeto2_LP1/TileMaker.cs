using System;
using System.Collections.Generic;

namespace Projeto2_LP1
{

    /// <summary>
    /// A Classe TileMaker implementa uma lista de objectos e possui uma 
    /// propriedade booleana e um constructor.
    /// </summary>
    public class TileMaker : List<Object>
    {

        /// <summary>
        /// Propriedade que permite transmitir a informação ao jogador, se algum
        /// objecto contido nesta lista já se encontra visivel ao jogador ou não.
        /// </summary>
        public bool Explored { get; set; }


        /// <summary>
        /// Este constructor ao usar a keyword base,faz com que seja possivel 
        /// utilizar os métodos necessários da classe genérica List nos objectos 
        /// que irão ser criados ao longo do jogo. ex: Add.
        /// </summary>
        public TileMaker() : base()
        {
            Explored = false;
        }
    }
}