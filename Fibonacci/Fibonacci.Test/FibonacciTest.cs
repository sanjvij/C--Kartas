using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci.Test
{
    class FibonacciTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FibonacciTest1()
        {
            string expected = "0,1,1,2,3,5,8,13,21,34,55,89,144";
            int n = 13;
            int startpos1 = 0;
            int startpos2 = 1;

            string output = Fibonacci.GetFibonacciSeries(startpos1, startpos2, n);
            Console.WriteLine(output);
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void FibonacciTest2()
        {
            string expected = "4,5,9,14,23";
            int n = 5;
            int startpos1 = 4;
            int startpos2 = 5;

            string output = Fibonacci.GetFibonacciSeries(startpos1, startpos2, n);
            Console.WriteLine(output);
            Assert.AreEqual(expected, output);
        }
    }
}
