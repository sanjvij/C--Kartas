using System;

namespace TennisScoring
{
    public class Game
    {
        public const string ServerWins = "ServerWins";
        public const string ReceiverWins = "RecieverWins";
        Score ServerScore;
        Score RecieverScore;
        bool _isDeuce;


        public Game(Score serverScore, Score recieverScore)
        {
            ServerScore = serverScore;
            RecieverScore = recieverScore;
        }

        public Game()
        {
            ServerScore = Score.Nill;
            RecieverScore = Score.Nill;
        }

        public void ServerWinsPoint()
        {

            if (RecieverScore == Score.Advantage)
            {
                RecieverScore = Score.GamePoint;
                _isDeuce = true;
                return;
            }
            CheckIsDeuce();
            ServerScore = GetWinningPoint(ServerScore);
        }

        private void CheckIsDeuce()
        {
            if (RecieverScore == Score.GamePoint && ServerScore == Score.GamePoint)
            {
                _isDeuce = true;
            }
        }

        public void RecieverWinsPoint()
        {
            CheckIsDeuce();
            if (ServerScore == Score.Advantage)
            {
                ServerScore = Score.GamePoint;
                _isDeuce = true;
                return;
            }
            RecieverScore = GetWinningPoint(RecieverScore);

        }

        private Score GetWinningPoint(Score score)
        {
            switch (score)
            {
                case Score.Nill:
                    return Score.FirstPoint;
                case Score.FirstPoint:
                    return Score.SecondPoint;
                case Score.SecondPoint:
                    return Score.GamePoint;
                case Score.GamePoint:
                    return _isDeuce ? Score.Advantage : Score.Win;
                case Score.Advantage:
                    return Score.Win;
                default:
                    throw new Exception("InvalidWinningPoint:" + score.GetHashCode());
            }
        }

        public string GetScore()
        {
            if (ServerScore == Score.Win)
                return ServerWins;

            if (RecieverScore == Score.Win)
                return ReceiverWins;

            return ServerScore.GetFormattedScore() + ":" + RecieverScore.GetFormattedScore();
        }
    }
}
