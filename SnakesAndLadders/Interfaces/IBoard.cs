using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    interface IBoard
    {
        int Start { get; set; }

        int End { get; set; }
    }
}
