namespace TennisScoring
{
    public static class ScoreExtention
    {
        public static string GetFormattedScore(this Score score)
        {
            if (score == Score.Advantage)
                return "A";

            return score.GetHashCode().ToString();
        }
    }
}
