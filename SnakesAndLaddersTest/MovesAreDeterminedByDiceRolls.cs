using Moq;
using NUnit.Framework;
using SnakesAndLadders;

namespace SnakesAndLadders.Tests
{
    public class MovesAreDeterminedByDiceRolls
    {
        Game _game;

        [SetUp]
        public void Setup()
        {
            _game = new Game();
        }

        [Test]
        public void Dice_Should_Roll_Minimum_Of_1()
        {
            var diceStub = new Mock<IDice>();
            diceStub.Setup(rdr => rdr.Roll()).Returns(0);

            _game = new Game(diceStub.Object);

            Assert.Throws<DiceMinimumRollException>(() => _game.RollDice());
        }

        [Test]
        public void Dice_Should_Roll_Maximum_Of_6()
        {
            var diceStub = new Mock<IDice>();
            diceStub.Setup(rdr => rdr.Roll()).Returns(7);

            _game = new Game(diceStub.Object);

            Assert.Throws<DiceMaximumRollException>(() => _game.RollDice());
        }

        [Test]
        public void Move_Player_Position_Based_On_Dice_Roll()
        {
            var diceStub = new Mock<IDice>();
            diceStub.Setup(rdr => rdr.Roll()).Returns(4);

            _game = new Game(diceStub.Object);
            _game.RollDice();
                
            int currentTokenPosition = _game.Player.CurrentPosition,
                expectedTokenPosition = 5;

            Assert.AreEqual(expectedTokenPosition, currentTokenPosition, "Token did not move 4 squares");
        }

        [TestCase(3)]
        [TestCase(5)]
        [TestCase(2)]
        [TestCase(4)]
        public void Move_Player_Position_Based_On_Random_Dice_Roll(int steps)
        {
            var diceStub = new Mock<IDice>();
            diceStub.Setup(rdr => rdr.Roll()).Returns(steps);

            _game = new Game(diceStub.Object);
            _game.RollDice();

            int currentTokenPosition = _game.Player.CurrentPosition,
                expectedTokenPosition = steps + 1;

            Assert.AreEqual(expectedTokenPosition, currentTokenPosition, "Token did not move " + steps + " squares");
        }
    }
}
