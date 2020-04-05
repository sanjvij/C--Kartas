namespace BowlingKata
{
    public class Frame
    {
        public int Score { get; set; }

        public int BonusBalls { get; private set; }

        public Frame(int bonusballs)
        {
            BonusBalls = bonusballs;
        }

        public void AdjustFrameScore(int pinsdown)
        {
            Score += pinsdown;
            BonusBalls--;
        }

        public Frame()
        {
            BonusBalls = 0;
        }

    }
}
