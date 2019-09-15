using Xunit;
using Shouldly;
using System.Collections.Generic;
using MusicalFizzBuzz.Library.Dto;

namespace MusicalFizzBuzz.Library.Tests
{
    public class SongPlayerShould
    {
        [Fact]
        public void ReturnIEnumerableOfNotes()
        {
            var player = new SongPlayer();

            var result = player.Play();
            
            result.ShouldBeOfType<List<Note>>();
        }
    }
}
