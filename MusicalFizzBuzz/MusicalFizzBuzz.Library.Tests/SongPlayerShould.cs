using Xunit;
using Shouldly;
using System.Collections.Generic;
using MusicalFizzBuzz.Library.Dto;
using System.Linq;

namespace MusicalFizzBuzz.Library.Tests
{
    public class SongPlayerShould
    {
        private int[] _noNumberNotes = new int[]
        {
            3,5,15
        };

        private Song _happyBirthday = new Song
        {
            Name = "Happy Birthday",
            Tempo = new Dictionary<string, int>
                {
                    { "Fizz", 2 },
                    { "Buzz", 4 },
                    { "FizzBuzz", 8 },
                    { "Rest", 6 }
                }
        };

        [Fact]
        public void ReturnListOfNotes()
        {
            var player = new SongPlayer(_happyBirthday);

            var result = player.Play(_noNumberNotes);
            
            result.ShouldBeOfType<List<Note>>();
            result.Count().ShouldBe(3);
        }

        [Fact]
        public void ReturnNotesThatMatchSong()
        {
            var player = new SongPlayer(_happyBirthday);

            var output = player.Play(_noNumberNotes).ToList();
            var result = $"{output[0]}{output[1]}{output[2]}";

            result.ShouldBe("FizzBuzzFizzBuzz");
        }

        [Fact]
        public void ReturnRestNotesWhenPassedNonConvertables()
        {
            var inputs = new int[]
            {
                3,5,15,7
            };

            var player = new SongPlayer(_happyBirthday);

            var result = player.Play(inputs);

            result.Last().ShouldBeOfType<Rest>();
        }

        [Fact]
        public void ReturnsNotesWithBeatValuesMatchingCorrectSong()
        {
            var inputNotes = new int[]
            {
                5,3,5,5,5,15
            };

            var player = new SongPlayer(_happyBirthday);

            var result = player.Play(inputNotes).ToList();

            result[1].Beats.ShouldBe(2);
            result[3].Beats.ShouldBe(4);
            result.Last().Beats.ShouldBe(8);
        }

        [Fact]
        public void ReturnsRestsWithBeatValuesMatchingCorrectSong()
        {
            var inputNotes = new int[]
            {
                5,4,5,7,5,15
            };

            var player = new SongPlayer(_happyBirthday);

            var result = player.Play(inputNotes).ToList();

            result[1].Beats.ShouldBe(6);
            result[3].Beats.ShouldBe(6);
            result.Last().Beats.ShouldBe(8);
        }
    }
}
