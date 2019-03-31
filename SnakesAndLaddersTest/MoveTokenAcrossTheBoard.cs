using NUnit.Framework;
using SnakesAndLadders;

namespace SnakesAndLadders.Tests
{
    public class MoveTokenAcrossTheBoard
    {
        Game _game;

        [SetUp]
        public void Setup()
        {
            _game = new Game();
        }

        [Test]
        public void Is_Token_On_Square_One()
        {
            int currentTokenPosition = _game.Player.CurrentPosition;
            Assert.IsTrue((currentTokenPosition == 1), "Token is not on square 1");
        }

        [Test]
        public void Token_Moves_Three_Sqaures()
        {
            _game.MoveToken(3);

            int currentTokenPosition = _game.Player.CurrentPosition,
                expectedTokenPosition = 4;

            Assert.AreEqual(expectedTokenPosition, currentTokenPosition, "Token did not move 3 squares");
        }

        [Test]
        public void Token_Moves_Are_Incremental()
        {
            _game.MoveToken(3);
            _game.MoveToken(4);

            int currentTokenPosition = _game.Player.CurrentPosition,
                expectedTokenPosition = 8;

            Assert.AreEqual(expectedTokenPosition, currentTokenPosition, "Token did not move to square 8");
        }


        [TestCase(6)]
        [TestCase(2)]
        public void Token_Moves_By_Given_Steps(int steps)
        {
            _game.MoveToken(steps);

            int currentTokenPosition = _game.Player.CurrentPosition,
                expectedTokenPosition = steps + 1;

            Assert.AreEqual(expectedTokenPosition, currentTokenPosition, "Token did not move " + steps + " squares");
        }
    }
}