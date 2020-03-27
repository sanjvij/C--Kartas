using FizzBuzzRunner;
using NUnit.Framework;
using System;


namespace Test.FizzBuzzRunner
{
    class MainProgramTest
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void AcceptNumbersCommaSepratedTest()
        {
            string input = "1,2,3,4";
            string expected = "1,2,fizz,4";
            string actual = FizzBuzz.RunFizzBuzz(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }



        [Test]
        public void AcceptNumbersCommaSepratedStringsIgnoredTest()
        {
            string input = "1,2,test,4";
            string expected = "1,2,4";
            string actual = FizzBuzz.RunFizzBuzz(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReplaceDivisibleBy3withFizz()
        {
            string input = "1,2,3,4";
            string expected = "1,2,fizz,4";
            string actual = FizzBuzz.RunFizzBuzz(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void ReplaceDivisibleBy5withBuzz()
        {
            string input = "1,2,3,4,5";
            string expected = "1,2,fizz,4,buzz";
            string actual = FizzBuzz.RunFizzBuzz(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }


    }
}
