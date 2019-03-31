using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    public interface IPlayer
    {
        //IDice Dice { get; set; }

        int CurrentPosition { get; set; }

        TurnResult TurnResult { get; set; }
        
        void TakePosition(int steps);

        //int RollDice();

        //void CalculateTurnResult(int currentPosition, int steps);

    }
}
