using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    public static class Fibonacci
    {
        public static string GetFibonacciSeries(int pos1, int pos2, int n)
        {
            string output = string.Empty;
            int startpos1 = pos1;
            int startpos2 = pos2;
            string COMMA = ",";

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    output += startpos1;
                    continue;
                }

                if (i == 1)
                {
                    output += COMMA + startpos2;
                    continue;
                }

                int sum = startpos1 + startpos2;
                output += COMMA + sum;

                startpos1 = startpos2;
                startpos2 = sum;
               
            }

            return output;
        }

    }
}
