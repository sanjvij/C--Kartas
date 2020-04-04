using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace TennisScoring.Test
{
    // Game to track the score... 
    // update score when a player wins a point
    // two players 
    // ability to check current score after each service
    // ability to raise some event that we have a winner (whevever detected) 

    /// <summary>
    /// 
    /// </summary>
    class TennisScoringTest
    {
        [SetUp]
        public void Setup()
        {
        }


        //Given the score is 0:0 When the server wins a point Then the score is 15:0
        [Test]
        public void GivenScoreNillBothServerWinsScoreis15toNillTest()
        {
            string expectedScore = "15:0";
            Game target = new Game();

            target.ServerWinsPoint();
            string actual = target.GetScore();
            Console.WriteLine(actual);
            Assert.AreEqual(expectedScore, actual);
        }

        //Given the score is 15:15 When the receiver wins a point Then the score is 15:30
        [Test]
        public void GivenScore15AllRecieverWinsScoreis15to30Test()
        {
            string expectedScore = "15:30";
            Game target = new Game(Score.FirstPoint, Score.FirstPoint);

            target.RecieverWinsPoint();
            string actual = target.GetScore();
            Console.WriteLine(actual);
            Assert.AreEqual(expectedScore, actual);
        }

        // //Given the score is 30:30 When the server wins a point Then the score is 40:30
        [Test]
        public void GivenScore30AllServerWinsScoreis40to30Test()
        {
            string expectedScore = "40:30";
            Game target = new Game(Score.SecondPoint, Score.SecondPoint);

            target.ServerWinsPoint();
            string actual = target.GetScore();
            Console.WriteLine(actual);
            Assert.AreEqual(expectedScore, actual);
        }

        //Given the score is 40:40 When the receiver wins a point Then the score should be 40:A

        [Test]
        public void GivenScore40AllRecieverWinsScoreis40toAdvTest()
        {
            string expectedScore = "40:A";
            Game target = new Game(Score.GamePoint, Score.GamePoint);

            target.RecieverWinsPoint();
            string actual = target.GetScore();
            Console.WriteLine(actual);
            Assert.AreEqual(expectedScore, actual);
        }


        //Given the score is 40:40 When the server wins a point Then the score should be A:40

        [Test]
        public void GivenScore40AllServerWinsScoreisAto40Test()
        {
            string expectedScore = "A:40";
            Game target = new Game(Score.GamePoint, Score.GamePoint);

            target.ServerWinsPoint();
            string actual = target.GetScore();
            Console.WriteLine(actual);
            Assert.AreEqual(expectedScore, actual);
        }


        //Given the score is A:40 When the receiver wins a point Then the score should be 40:40
        [Test]
        public void GivenScoreAto40ReceiverWinsScoreis40to40Test()
        {
            string expectedScore = "40:40";
            Game target = new Game(Score.Advantage, Score.GamePoint);

            target.RecieverWinsPoint();
            string actual = target.GetScore();
            Console.WriteLine(actual);
            Assert.AreEqual(expectedScore, actual);
        }


        //Given the score is 40:A When the receiver wins a point Then the score should be 40:40
        [Test]
        public void GivenScore40toAServerWinsScoreis40to40Test()
        {
            string expectedScore = "40:40";
            Game target = new Game(Score.GamePoint, Score.Advantage);

            target.ServerWinsPoint();
            string actual = target.GetScore();
            Console.WriteLine(actual);
            Assert.AreEqual(expectedScore, actual);
        }


        //Given the score is 40:30 When the server wins a point Then the server should win
        [Test]
        public void GivenScore40to30ServerWinsScoreIsServerWins()
        {
            string expectedScore = Game.ServerWins;
            Game target = new Game(Score.GamePoint, Score.SecondPoint);

            target.ServerWinsPoint();
            string actual = target.GetScore();
            Console.WriteLine(actual);
            Assert.AreEqual(expectedScore, actual);

        }

        //Given the score is 30:40 When the reciever wins a point Then the reciever should win
        [Test]
        public void GivenScore30to40RecieverWinsScoreIsReceiverWins()
        {
            string expectedScore = Game.ReceiverWins;
            Game target = new Game(Score.SecondPoint, Score.GamePoint);

            target.RecieverWinsPoint();
            string actual = target.GetScore();
            Console.WriteLine(actual);
            Assert.AreEqual(expectedScore, actual);
        }

        //Given the score is 40:A When the receiver wins a point Then the receiver should win
        [Test]
        public void GivenScore40toARecieverWinsScoreIsReceiverWins()
        {
            string expectedScore = Game.ReceiverWins;
            Game target = new Game(Score.GamePoint, Score.Advantage);

            target.RecieverWinsPoint();
            string actual = target.GetScore();
            Console.WriteLine(actual);
            Assert.AreEqual(expectedScore, actual);
        }




        //Given the score is A:40 When the server wins a point Then the server should win
        [Test]
        public void GivenScore40toAServerWinsScoreIsServerWins()
        {
            string expectedScore = Game.ServerWins;
            Game target = new Game(Score.Advantage, Score.GamePoint);

            target.ServerWinsPoint();
            string actual = target.GetScore();
            Console.WriteLine(actual);
            Assert.AreEqual(expectedScore, actual);
        }
    }

}
