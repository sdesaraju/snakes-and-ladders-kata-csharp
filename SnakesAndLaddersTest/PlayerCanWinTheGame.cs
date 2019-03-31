using NUnit.Framework;
using SnakesAndLadders;

namespace SnakesAndLadders.Tests
{
    public class PlayerCanWinTheGame
    {
        Game _game;

        [SetUp]
        public void Setup()
        {
            _game = new Game(97);
        }

        [Test]
        public void Player_Wins_The_Game_When_Token_Is_Moved_Three_Spaces()
        {
            _game.MoveToken(3);

            TurnResult turnResult = _game.Player.TurnResult,
                expectedResult = TurnResult.Won;

            Assert.AreEqual(expectedResult, turnResult, "Player did not win the game!");
        }

        [Test]
        public void Player_Do_Not_Win_The_Game_When_Token_Is_Moved_Four_Spaces()
        {
            _game.MoveToken(4);

            TurnResult turnResult = _game.Player.TurnResult,
                expectedResult = TurnResult.BoardLimitExceeded;

            Assert.AreEqual(expectedResult, turnResult, "Turn Invalid and token was not moved!");
        }

        [Test]
        public void Player_Stays_On_Current_Square_If_Move_Exceeds_Board_Limit()
        {
            _game.MoveToken(4);

            int currentTokenPosition = _game.Player.CurrentPosition;

            Assert.AreEqual(currentTokenPosition, 97);
        }

        [Test]
        public void Player_Wins_The_Game_With_Incremental_Moves()
        {
            _game.MoveToken(2);
            _game.MoveToken(1);

            TurnResult turnResult = _game.Player.TurnResult,
                expectedResult = TurnResult.Won;

            Assert.AreEqual(expectedResult, turnResult, "Player did not win the game!");
        }
    }
}
