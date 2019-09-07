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
    }
}
