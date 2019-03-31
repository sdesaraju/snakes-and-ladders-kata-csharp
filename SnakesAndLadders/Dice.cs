using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    class Dice : IDice
    {
        public int Roll()
        {
            Random random = new Random();

            return random.Next(1, 7);
        }
    }
}
