using System;
using System.Collections.Generic;

namespace Projeto2_LP1
{
    public class TileMaker : List<Object>
    {
        public bool Explored { get; set; }

        public TileMaker() : base()
        {
            Explored = false;
        }
    }
}