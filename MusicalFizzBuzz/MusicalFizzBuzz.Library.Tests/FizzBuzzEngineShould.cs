using Xunit;
using Shouldly;
using System.Collections.Generic;

namespace MusicalFizzBuzz.Library.Tests
{
    public class FizzBuzzEngineShould
    {
        private FizzBuzzEngine _fizzBuzz = new FizzBuzzEngine();
        private List<string> _results;

        [Theory]
        [InlineData(2, "2")]
        [InlineData(8, "8")]
        [InlineData(14, "14")]
        public void ReturnNumberWhenNotSpecial(int testInput, 
            string expectedResult)
        {
            var result = _fizzBuzz.Process(testInput);

            result.ShouldBe(expectedResult);
        }

        [Fact]
        public void ReturnFizzWhenThree()
        {
            var result = _fizzBuzz.Process(3);

            result.ShouldBe("Fizz");
        }

        [Theory]
        [InlineData(6, 9, 12, 18, 36, 303)]
        public void ReturnFizzWhenMultipleOfThree(params int[] testInputs)
        {
            LoadResultsList(testInputs);

            _results.ShouldAllBe(result => result.Equals("Fizz"));
        }

        [Fact]
        public void ReturnBuzzWhenFive()
        {
            var result = _fizzBuzz.Process(5);

            result.ShouldBe("Buzz");
        }

        [Theory]
        [InlineData(10,20,100,4000)]
        public void ReturnBuzzWhenMultipleOfFive(params int[] testInputs)
        {
            LoadResultsList(testInputs);

            _results.ShouldAllBe(result => result.Equals("Buzz"));
        }

        [Theory]
        [InlineData(15,30,45,300,1500)]
        public void ReturnFizzBuzzForMultiplesOfThreeAndFive(params int[] testInputs)
        {
            LoadResultsList(testInputs);

            _results.ShouldAllBe(result => result.Equals("FizzBuzz"));
        }

        private void LoadResultsList(int[] testInputs)
        {
            _results = new List<string>();

            foreach (var input in testInputs)
            {
                _results.Add(_fizzBuzz.Process(input));
            }
        }
    }
}
