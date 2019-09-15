using Xunit;
using Shouldly;
using System.Collections.Generic;
using MusicalFizzBuzz.Library.Dto;
using System.Linq;
using static MusicalFizzBuzz.Library.Globals;

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
                    { Notes.FIZZ, 2 },
                    { Notes.BUZZ, 4 },
                    { Notes.FIZZ_BUZZ, 8 },
                    { Notes.REST, 6 }
                }
        };

        private SongPlayer _player;

        public SongPlayerShould()
        {
            _player = new SongPlayer(_happyBirthday);
        }

        [Fact]
        public void ReturnListOfNotes()
        {
            var result = _player.Play(_noNumberNotes);
            
            result.ShouldBeOfType<List<Note>>();
            result.Count().ShouldBe(3);
        }

        [Fact]
        public void ReturnNotesThatMatchSong()
        {
            var output = _player.Play(_noNumberNotes).ToList();
            var result = $"{output[0]}{output[1]}{output[2]}";

            result.ShouldBe($"{Notes.FIZZ}{Notes.BUZZ}{Notes.FIZZ_BUZZ}");
        }

        [Fact]
        public void ReturnRestNotesWhenPassedNonConvertables()
        {
            var inputs = new int[]
            {
                3,5,15,7
            };

            var result = _player.Play(inputs);

            result.Last().ShouldBeOfType<Rest>();
        }

        [Fact]
        public void ReturnsNotesWithBeatValuesMatchingCorrectSong()
        {
            var inputNotes = new int[]
            {
                5,3,5,5,5,15
            };

            var result = _player.Play(inputNotes).ToList();

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

            var result = _player.Play(inputNotes).ToList();

            result[1].Beats.ShouldBe(6);
            result[3].Beats.ShouldBe(6);
            result.Last().Beats.ShouldBe(8);
        }
    }
}
