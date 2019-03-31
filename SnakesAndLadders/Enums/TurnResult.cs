using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    public enum TurnResult
    {
        Move,
        Won,
        BoardLimitExceeded,
        Snake,
        Ladder
    }
}
