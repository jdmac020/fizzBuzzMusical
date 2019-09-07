using System;
using Xunit;
using MusicalFizzBuzz.Library;
using Shouldly;
using System.Collections.Generic;

namespace MusicalFizzBuzz.Library.Tests
{
    public class FizzBuzzEngineShould
    {
        [Theory]
        [InlineData(2, "2")]
        [InlineData(8, "8")]
        [InlineData(14, "14")]
        public void ReturnNumberWhenNotSpecial(int testInput, 
            string expectedResult)
        {
            var fizzBuzz = new FizzBuzzEngine();

            var result = fizzBuzz.Process(testInput);

            result.ShouldBe(expectedResult);
        }

        [Fact]
        public void ReturnFizzWhenThree()
        {
            var fizzBuzz = new FizzBuzzEngine();

            var result = fizzBuzz.Process(3);

            result.ShouldBe("Fizz");
        }

        [Theory]
        [InlineData(6, 9, 12, 18, 36, 303)]
        public void ReturnFizzWhenMultipleOfThree(params int[] testInputs)
        {
            var fizzBuzz = new FizzBuzzEngine();
            var results = new List<string>();

            foreach (var input in testInputs)
            {
                results.Add(fizzBuzz.Process(input));
            }

            results.ShouldAllBe(result => result.Equals("Fizz"));
        }

        [Fact]
        public void ReturnBuzzWhenFive()
        {
            var fizzBuzz = new FizzBuzzEngine();

            var result = fizzBuzz.Process(5);

            result.ShouldBe("Buzz");
        }

        [Theory]
        [InlineData(10,20,100,4000)]
        public void ReturnBuzzWhenMultipleOfFive(params int[] testInputs)
        {
            var fizzBuzz = new FizzBuzzEngine();
            var results = new List<string>();

            foreach (var input in testInputs)
            {
                results.Add(fizzBuzz.Process(input));
            }

            results.ShouldAllBe(result => result.Equals("Buzz"));
        }

        [Fact]
        public void ReturnFizzBuzzWhenFifteen()
        {
            var fizzBuzz = new FizzBuzzEngine();

            var result = fizzBuzz.Process(15);

            result.ShouldBe("FizzBuzz");
        }

        [Theory]
        [InlineData(30,45,300,1500)]
        public void ReturnFizzBuzzForMultiplesOfThreeAndFive(params int[] testInputs)
        {
            var fizzBuzz = new FizzBuzzEngine();
            var results = new List<string>();

            foreach (var input in testInputs)
            {
                results.Add(fizzBuzz.Process(input));
            }

            results.ShouldAllBe(result => result.Equals("FizzBuzz"));
        }
    }
}
