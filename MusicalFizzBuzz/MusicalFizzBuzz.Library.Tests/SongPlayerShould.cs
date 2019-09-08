using Xunit;
using Shouldly;
using System.Collections.Generic;

namespace MusicalFizzBuzz.Library.Tests
{
    public class SongPlayerShould
    {
        [Fact]
        public void ConvertIntIEnumerableToStringIEnumerable()
        {
            IEnumerable<int> testArray = new int[]
            {
                3,5,15
            };
            var expectedReturn = new List<string> { "3","5","15" };

            var songPlayer = new SongPlayer();

            var result = songPlayer.Play(testArray);

            result.ShouldBe(expectedReturn);
        }
    }
}
