using Xunit;
using Shouldly;

namespace MusicalFizzBuzz.Library.Tests
{
    public class SongPlayerShould
    {
        [Fact]
        public void ConvertIntArrayToSpaceDelimitedString()
        {
            var testArray = new int[]
            {
                3,5,15
            };
            var expectedReturn = "Fizz Buzz FizzBuzz";

            var songPlayer = new SongPlayer();

            var result = songPlayer.Play(testArray);

            result.ShouldBe(expectedReturn);
        }
    }
}
