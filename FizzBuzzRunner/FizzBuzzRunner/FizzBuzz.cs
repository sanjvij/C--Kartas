using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzRunner
{
    public static class FizzBuzz
    {

        public static string RunFizzBuzz(string input)
        {
            string[] names = input.Split(',');
            string output = string.Empty;

            foreach (var item in names)
            {
                if (int.TryParse(item, out int result))
                {
                    string magicWord = result % 3 == 0 ? "fizz" : result.ToString();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        output += magicWord;
                    }
                    else
                    {
                        output += "," + magicWord;
                    }

                }

            }

            return output;
        }

    }
}
