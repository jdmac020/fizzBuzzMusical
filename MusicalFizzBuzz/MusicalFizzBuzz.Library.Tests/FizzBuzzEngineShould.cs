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
        public void ReturnNumber(int testInput, 
            string expectedResult)
        {
            var fizzBuzz = new FizzBuzzEngine();

            var result = fizzBuzz.Process(testInput);

            result.ShouldBe(expectedResult);
        }
    }
}
