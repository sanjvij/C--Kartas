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
            game.RollBall(4);
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
            game.RollBall(10);
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
            game.RollBall(4);
            game.RollBall(3);
            int actual = game.GetActiveFrameNumber();
            int expected = 2;
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A Spare gives you one bonus ball 
        /// </summary>
        [Test]
        public void SpareGivesYouABonusBallRoll()
        {
            BowlingKataGame game = new BowlingKataGame();
            game.RollBall(4);
            game.RollBall(6);
            int actualFrameNumber = game.GetActiveFrameNumber();
            int expectedFrameNumber = 2;

            int actualBonusBalls = game.GetRemainingBonusBalls();
            int expectedBonusBalls = 1;
            Console.WriteLine("Actual Frame" + actualFrameNumber);
            Console.WriteLine("Actual BonusBalls" + actualBonusBalls);
            Assert.AreEqual(expectedFrameNumber, actualFrameNumber);
            Assert.AreEqual(expectedBonusBalls, actualBonusBalls);

        }

        /// <summary>
        /// If you hit a strike then you get two bonus balls
        /// </summary>
        [Test]
        public void StrikeGivesYouTwoBonusBalls()
        {
            BowlingKataGame game = new BowlingKataGame();
            game.RollBall(10);

            int actualFrameNumber = game.GetActiveFrameNumber();
            int expectedFrameNumber = 2;

            int actualBonusBalls = game.GetRemainingBonusBalls();
            int expectedBonusBalls = 2;
            Console.WriteLine("Actual Frame" + actualFrameNumber);
            Console.WriteLine("Actual BonusBalls" + actualBonusBalls);
            Assert.AreEqual(expectedFrameNumber, actualFrameNumber);
            Assert.AreEqual(expectedBonusBalls, actualBonusBalls);
        }


        [Test]
        public void GetScorseWhenAStrike()
        {
            BowlingKataGame game = new BowlingKataGame();
            game.RollBall(10);

            int actualFrameNumber = game.GetActiveFrameNumber();
            int expectedFrameNumber = 2;

            int actualBonusBalls = game.GetRemainingBonusBalls();
            int expectedBonusBalls = 2;
            Console.WriteLine("Actual Frame" + actualFrameNumber);
            Console.WriteLine("Actual BonusBalls" + actualBonusBalls);
            Assert.AreEqual(expectedFrameNumber, actualFrameNumber);
            Assert.AreEqual(expectedBonusBalls, actualBonusBalls);
            int actualScore = game.GetScores();
            int expectedScore = 10;

            Assert.AreEqual(expectedScore, actualScore);

        }


        [Test]
        public void GetScoresWhenASpare()
        {
            BowlingKataGame game = new BowlingKataGame();
            game.RollBall(8);
            game.RollBall(2);

            int actualFrameNumber = game.GetActiveFrameNumber();
            int expectedFrameNumber = 2;

            int actualBonusBalls = game.GetRemainingBonusBalls();
            int expectedBonusBalls = 1;
            Console.WriteLine("Actual Frame" + actualFrameNumber);
            Console.WriteLine("Actual BonusBalls" + actualBonusBalls);
            Assert.AreEqual(expectedFrameNumber, actualFrameNumber);
            Assert.AreEqual(expectedBonusBalls, actualBonusBalls);
            int actualScore = game.GetScores();
            int expectedScore = 10;

            Assert.AreEqual(expectedScore, actualScore);
        }



        [Test]
        public void GetFrameScoreScenario1()
        {
            BowlingKataGame game = new BowlingKataGame();

            game.RollBall(6);
            game.RollBall(4);

            Assert.AreEqual(10, game.GetScorebyFrame(1));

            game.RollBall(7);
            Assert.AreEqual(17, game.GetScorebyFrame(1));
            game.RollBall(1);
            Assert.AreEqual(17, game.GetScorebyFrame(1));
            Assert.AreEqual(25, game.GetScorebyFrame(2));
        }



        [Test]
        public void GetFrameScoreScenario2BonusPointsAddedtoCorrectFrame()
        {
            BowlingKataGame game = new BowlingKataGame();

            game.RollBall(10);
            game.RollBall(4);
            game.RollBall(6);
            Assert.AreEqual(30, game.GetScores());

        }


        [Test]
        public void GetFrameScoreScenario3Game10IsStrikeAllowstwoMoreBalls()
        {
            BowlingKataGame game = new BowlingKataGame();

            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);


            Assert.AreEqual(300, game.GetScores());
            Assert.AreEqual(0, game.GetRemainingBonusBalls());
            Assert.AreEqual(10, game.GetActiveFrameNumber());

            game.RollBall(10);// this ball should be ignored... 
            Assert.AreEqual(300, game.GetScores());
            Assert.AreEqual(0, game.GetRemainingBonusBalls());
            Assert.AreEqual(10, game.GetActiveFrameNumber());
        }


        [Test]
        public void GetFrameScoreScenario3Game10IsStrikeAllowsOneMoreBalls()
        {
            BowlingKataGame game = new BowlingKataGame();

            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(10);
            game.RollBall(2);//9
            game.RollBall(8);//9
            game.RollBall(2);
            game.RollBall(8);
            game.RollBall(10);

            game.PrintScores();

           // Assert.AreEqual(278, game.GetScores());
            Assert.AreEqual(0, game.GetRemainingBonusBalls());
            Assert.AreEqual(10, game.GetActiveFrameNumber());
        }


    }
}
