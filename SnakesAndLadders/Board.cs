using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    class Board : IBoard
    {
        public int Start { get; set; }
        public int End { get; set; }
    }
}
