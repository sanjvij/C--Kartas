using NUnit.Framework;
using System;

namespace BowlingKata.Test
{
    class BowlingKataTest
    {
        [SetUp]
        public void Setup()
        {
        }


        /// <summary>
        ///
        /// If you have rolled only one ball and all pins are not down, then the next frame will not start..    
        /// </summary>
        [Test]
        public void OneRollOfBallDoesNotStartNewFrameIfAllPinsNotDownTest()
        {
            BowlingKataGame game = new BowlingKataGame();
            game.RollBal(4);
            int actual = game.GetActiveFrameNumber();
            int expected = 1;
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If you have knocked all pins on first ball, then the next frame will start
        /// </summary>
        [Test]
        public void OneRollOfBallStartNewFrameIfAllPinsDownTest()
        {
            // Means if you have rolled only one ball, then the next frame will not start.. 
            // third roll will be a start of next frame

            BowlingKataGame game = new BowlingKataGame();
            game.RollBal(10);
            int actual = game.GetActiveFrameNumber();
            int expected = 2;
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// if you have rolled two balls but all pins are not down, the next frame will start
        /// </summary>
        [Test]
        public void TwoRollOfBallsStartsNewFrameTest()
        {
            // Means if you have rolled two balls, then the next frame will start.. 
            // third roll will be a start of next frame

            BowlingKataGame game = new BowlingKataGame();
            game.RollBal(4);
            game.RollBal(3);
            int actual = game.GetActiveFrameNumber();
            int expected = 2;
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

    }
}
