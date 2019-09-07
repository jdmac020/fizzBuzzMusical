using System;
using Xunit;
using MusicalFizzBuzz.Library;
using Shouldly;

namespace MusicalFizzBuzz.Library.Tests
{
    public class FizzBuzzEngineShould
    {
        [Fact]
        public void ReturnNumber()
        {
            var fizzBuzz = new FizzBuzzEngine();

            var result = fizzBuzz.Process(3);

            result.ShouldBe("3");
        }
    }
}
