using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    public class Game
    {
        IBoard _board;
        IDice _dice;
        public IPlayer Player;

        public Game()
        {
            _dice = new Dice();

            _board = new Board()
            {
                Start = 1,
                End = 100
            };

            Player = new Player()
            {
                CurrentPosition = 1
            };
        }

        public Game(int _currentPosition)
        {
            _dice = new Dice();

            _board = new Board()
            {
                Start = 1,
                End = 100
            };

            Player = new Player()
            {
                CurrentPosition = _currentPosition
            };
        }

        public Game(IDice _tempDice)
        {
            _dice = _tempDice;

            _board = new Board()
            {
                Start = 1,
                End = 100
            };

            Player = new Player()
            {
                CurrentPosition = 1
            };
        }

        public void RollDice()
        {
            int steps = _dice.Roll();

            if (steps < 1)
                throw new DiceMinimumRollException();
            else if (steps > 6)
                throw new DiceMaximumRollException();

            MoveToken(steps);
        }

        public void MoveToken(int steps)
        {
            int currentPosition = Player.CurrentPosition,
                nextPosition = currentPosition + steps;

            if (nextPosition == _board.End)
            {
                Player.TurnResult = TurnResult.Won;
            }
            else if (nextPosition > _board.End)
            {
                Player.TurnResult = TurnResult.BoardLimitExceeded;
            }
            else
            {
                Player.TurnResult = TurnResult.Move;
                Player.TakePosition(steps);
            }
        }
    }
}
