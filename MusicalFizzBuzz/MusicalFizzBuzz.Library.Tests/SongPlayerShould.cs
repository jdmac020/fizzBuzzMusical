using Xunit;
using Shouldly;
using System.Collections.Generic;
using MusicalFizzBuzz.Library.Dto;
using System.Linq;

namespace MusicalFizzBuzz.Library.Tests
{
    public class SongPlayerShould
    {
        [Fact]
        public void ReturnListOfNotes()
        {
            var player = new SongPlayer();
            var noteInputs = new int[]
            {
                3,5,15
            };

            var result = player.Play(noteInputs);
            
            result.ShouldBeOfType<List<Note>>();
            result.Count().ShouldBe(3);
        }
    }
}
