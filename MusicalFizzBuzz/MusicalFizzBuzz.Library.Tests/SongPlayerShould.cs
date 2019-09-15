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
            var player = new SongPlayer(new Song());
            var noteInputs = new int[]
            {
                3,5,15
            };

            var result = player.Play(noteInputs);
            
            result.ShouldBeOfType<List<Note>>();
            result.Count().ShouldBe(3);
        }

        [Fact]
        public void ReturnNotesThatMatchSong()
        {
            var song = new Song
            {
                Name = "FizzBuzz"
            };

            var inputs = new int[]
            {
                3,5,15
            };

            var player = new SongPlayer(song);

            var output = player.Play(inputs).ToList();
            var result = $"{output[0]}{output[1]}{output[2]}";

            result.ShouldBe("FizzBuzzFizzBuzz");
        }
    }
}
