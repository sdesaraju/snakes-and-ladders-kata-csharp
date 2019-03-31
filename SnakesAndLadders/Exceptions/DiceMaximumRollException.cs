using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    public class DiceMaximumRollException: Exception
    {
        public DiceMaximumRollException()
        {
            throw new DiceMaximumRollException("Maximum value for Dice Roll is 6.");
        }

        public DiceMaximumRollException(string message) : base(message)
        {
        }
    }
}
