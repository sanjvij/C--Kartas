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
        public void Test1()
        {
            Assert.Pass();
        }


        [Test]
        public void AcceptNumbersCommaSepratedTest()
        {
            var input = "1,2,3,4";
            var expected = "1,2,3,4";
            var actual = FizzBuzz.RunFizzBuzz(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }



        [Test]
        public void AcceptNumbersCommaSepratedStringsIgnoredTest()
        {
            var input = "1,2,test,4";
            var expected = "1,2,4";
            var actual = FizzBuzz.RunFizzBuzz(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReplaceDivisibleBy3withFizz()
        {
            var input = "1,2,3,4";
            var expected = "1,2,fizz,4";
            var actual = FizzBuzz.RunFizzBuzz(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }


    }
}
