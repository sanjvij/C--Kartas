using System;
using System.Collections.Generic;

namespace GreedKata
{
    public enum DiceValue
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6
    }

    public class Game
    {
        Dictionary<DiceValue, int> pointSystem = new Dictionary<DiceValue, int>()
        {
            { DiceValue.One, 100 },
            { DiceValue.Two, 0 },
            { DiceValue.Three, 0 },
            { DiceValue.Four, 0 },
            { DiceValue.Five, 0 },
            { DiceValue.Six , 0 },
        };

        public int RollDice(DiceValue v1, DiceValue v2, DiceValue v3, DiceValue v4, DiceValue v5, DiceValue v6)
        {
            int score = 0;
            score += pointSystem.GetValueOrDefault(v1);
            score += pointSystem.GetValueOrDefault(v2);
            score += pointSystem.GetValueOrDefault(v3);
            score += pointSystem.GetValueOrDefault(v4);
            score += pointSystem.GetValueOrDefault(v5);
            score += pointSystem.GetValueOrDefault(v6);
            return score;
        }
    }
}
