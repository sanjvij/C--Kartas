using GreedKata;
using NUnit.Framework;
using System;

namespace Tests
{
    public class GameTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SingleOne100PointsScenario1()
        {
            Game greed = new Game();
            int actual = greed.RollDice(DiceValue.One, DiceValue.Two, DiceValue.Three, DiceValue.Four, DiceValue.Five, DiceValue.Six);
            int expected = 100;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SingleOne100PointsScenario2()
        {
            Game greed = new Game();
            int actual = greed.RollDice(DiceValue.One, DiceValue.Two, DiceValue.One, DiceValue.Four, DiceValue.One, DiceValue.Six);
            int expected = 300;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SingleOne100PointsScenario3()
        {
            Game greed = new Game();
            int actual = greed.RollDice(DiceValue.Three, DiceValue.Two, DiceValue.Three, DiceValue.Four, DiceValue.Three, DiceValue.Six);
            int expected = 0;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

    }
}