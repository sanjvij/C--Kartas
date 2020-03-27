using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzRunner
{
    public class FizzBuzz
    {

        public string RunFizzBuzz(string input)
        {
            string[] names = input.Split(',');
            string output = string.Empty;

            foreach (var item in names)
            {
                if (int.TryParse(item, out int result))
                {
                    if (string.IsNullOrWhiteSpace(output))
                    {
                        output += result;
                    }
                    else
                    {
                        output += "," + result;
                    }

                }

            }

            return output;
        }

    }
}
