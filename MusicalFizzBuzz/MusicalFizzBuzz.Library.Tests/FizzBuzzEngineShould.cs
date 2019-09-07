using System;
using Xunit;
using MusicalFizzBuzz.Library;
using Shouldly;

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
        public void ReturnFizzWhenFactorOfThree()
        {
            var fizzBuzz = new FizzBuzzEngine();

            var result = fizzBuzz.Process(3);

            result.ShouldBe("Fizz");
        }
    }
}
