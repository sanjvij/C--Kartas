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
                if (string.IsNullOrWhiteSpace(output))
                {
                    output += item;
                }
                else
                {
                    output += "," + item;
                }
            }

            return output;
        }

    }
}
