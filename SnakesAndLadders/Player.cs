using System;

namespace SnakesAndLadders
{
    public class Player : IPlayer
    {
        public int CurrentPosition { get; set; }
        public TurnResult TurnResult { get; set; }

        public void TakePosition(int steps)
        {
            CurrentPosition += steps;
        }
    }
}
