using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    public class DiceMinimumRollException: Exception
    {
        public DiceMinimumRollException()
        {
            throw new DiceMinimumRollException("Minimum value for Dice Roll is 1.");
        }

        public DiceMinimumRollException(string message) : base(message)
        {
        }
    }
}
