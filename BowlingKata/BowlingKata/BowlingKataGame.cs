using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BowlingKata
{
    public class BowlingKataGame
    {

        public Frame[] Frames { get; private set; } = new Frame[10];

        public int ActiveFrameNumber { get; private set; } = 1;

        public int ActiveGameScore { get; private set; } = 0;

        public int ActiveFrameScore { get; private set; } = 0;

        public int Attempts { get; private set; } = 0;

        public int BonusBalls { get; private set; } = 0;

        public void RollBall(int numberOfPinsKnocked)
        {
            try
            {
                if (ActiveFrameNumber == 10 && Attempts > 2 || ActiveFrameNumber > 10)
                {
                    return;
                }
                Attempts++;
                ActiveFrameScore += numberOfPinsKnocked;
                ActiveGameScore += numberOfPinsKnocked;

                AdjustAllFrames(numberOfPinsKnocked);

                if (ActiveFrameNumber < 10)
                {
                    if (ActiveFrameScore == 10)
                    {
                        if (Attempts == 2)
                            BonusBalls++;
                        else
                            BonusBalls += 2;
                    }
                    if (ActiveFrameScore == 10 || Attempts == 2)
                    {
                        AdjustFrameScore();
                    }
                }
                else
                {
                    if (Frames[ActiveFrameNumber - 1] == null)
                    {
                        Frames[ActiveFrameNumber - 1] = new Frame(BonusBalls)
                        {
                            Score = ActiveFrameScore
                        };
                    }
                    else
                    {
                        Frames[ActiveFrameNumber - 1].Score = ActiveFrameScore;
                    }
                }
            }
            finally
            {
                PrintScores();
            }
        }

        private void AdjustFrameScore()
        {
            Frames[ActiveFrameNumber - 1] = new Frame(BonusBalls)
            {
                Score = ActiveFrameScore
            };

            ActiveFrameScore = 0;
            ActiveFrameNumber++;
            Attempts = 0;
            BonusBalls = 0;
        }

        private void AdjustAllFrames(int adjustedPins)
        {
            for (int i = 0; i < Frames.Length; i++)
            {
                if (Frames[i] == null)
                    break;
                if (Frames[i] != null && Frames[i].BonusBalls > 0)
                {
                    Frames[i].AdjustFrameScore(adjustedPins);
                    ActiveGameScore += adjustedPins;
                }
            }
        }


        public int GetActiveFrameNumber()
        {
            return ActiveFrameNumber;
        }

        public int GetRemainingBonusBalls()
        {
            int retValue = 0;
            for (int i = 0; i < Frames.Length; i++)
            {
                if (Frames[i] == null)
                    break;
                if (Frames[i] != null)
                    retValue += Frames[i].BonusBalls;
            }

            return retValue;
        }

        public int GetScores()
        {
            return ActiveGameScore;
        }

        public int GetScorebyFrame(int frameNumber)
        {
            return Frames[frameNumber - 1].Score;
        }

        public void PrintScores()
        {
            Debug.WriteLine("***************Scores***************");
            for (int i = 0; i < Frames.Length; i++)
            {

                if (Frames[i] != null)
                {
                    Debug.WriteLine($"Frame {i + 1} : {Frames[i].Score}  Bonus Balls Left : {Frames[i].BonusBalls} Active Game Score : {ActiveGameScore}");
                }

            }

            Debug.WriteLine($"Game: {ActiveGameScore}");

        }

    }
}
