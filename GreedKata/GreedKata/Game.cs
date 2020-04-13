using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKata
{
    public enum DiceValue
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6
    }

    public static class DiceValueExtention
    {
        public static string GetValue(this DiceValue value)
        {
            return value.GetHashCode().ToString();
        }

    }

    public class Game
    {
        Dictionary<DiceValue, int> pointSystem = new Dictionary<DiceValue, int>()
        {
            { DiceValue.Zero, 0 },
            { DiceValue.One, 100 },
            { DiceValue.Two, 0 },
            { DiceValue.Three, 0 },
            { DiceValue.Four, 0 },
            { DiceValue.Five, 50 },
            { DiceValue.Six , 0 },
        };

        public int RollDice(DiceValue v1, DiceValue v2, DiceValue v3, DiceValue v4, DiceValue v5, DiceValue v6)
        {
            int score = 0;
            int[] inputAsIntArray = new int[6] { v1.GetHashCode(), v2.GetHashCode(), v3.GetHashCode(), v4.GetHashCode(), v5.GetHashCode(), v6.GetHashCode() };

            Array.Sort(inputAsIntArray);

            string inputAsStringPattern = inputAsIntArray[0].ToString() + inputAsIntArray[1].ToString() + inputAsIntArray[2].ToString() + inputAsIntArray[3].ToString() + inputAsIntArray[4].ToString() + inputAsIntArray[5].ToString();


            switch (inputAsStringPattern)
            {
                case "111111":
                    score = 2000;
                    inputAsStringPattern = "";
                    break;
                case "222222":
                    score = 400;
                    inputAsStringPattern = "";
                    break;
                case "333333":
                    score = 600;
                    inputAsStringPattern = "";
                    break;
                case "444444":
                    score = 800;
                    inputAsStringPattern = "";
                    break;
                case "555555":
                    score = 1000;
                    inputAsStringPattern = "";
                    break;
                default:
                    if (inputAsStringPattern.Contains("111"))
                    {
                        score += 1000;
                        inputAsStringPattern = inputAsStringPattern.Replace("111", "0");
                    }
                    if (inputAsStringPattern.Contains("222"))
                    {
                        score += 200;
                        inputAsStringPattern = inputAsStringPattern.Replace("222", "0");
                    }
                    if (inputAsStringPattern.Contains("333"))
                    {
                        score += 300;
                        inputAsStringPattern = inputAsStringPattern.Replace("333", "0");
                    }
                    if (inputAsStringPattern.Contains("444"))
                    {
                        score += 400;
                        inputAsStringPattern = inputAsStringPattern.Replace("444", "0");
                    }
                    if (inputAsStringPattern.Contains("555"))
                    {
                        score += 500;
                        inputAsStringPattern = inputAsStringPattern.Replace("555", "0");
                    }
                    break;
            }

            if (string.IsNullOrWhiteSpace(inputAsStringPattern))
            {
                return score;
            }

            foreach (var item in inputAsStringPattern)
            {
                DiceValue val = (DiceValue)int.Parse(item.ToString());
                score += pointSystem.GetValueOrDefault(val);
            }
            return score;
        }
    }
}
