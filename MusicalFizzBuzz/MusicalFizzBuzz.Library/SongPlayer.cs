using MusicalFizzBuzz.Library.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicalFizzBuzz.Library
{
    public class SongPlayer
    {
        private FizzBuzzEngine _fizzBuzz;
        private Song _song;

        public SongPlayer(Song song)
        {
            _fizzBuzz = new FizzBuzzEngine();
            _song = song;
        }

        public IEnumerable<Note> Play(int[] noteInputs)
        {
            var noteList = new List<Note>();

            foreach (var note in noteInputs)
            {
                var fizzBuzz = _fizzBuzz.Process(note);

                if (int.TryParse(fizzBuzz,out int i))
                {
                    noteList.Add(new Rest());
                }
                else
                {
                    noteList.Add(new Note
                    {
                        Value = fizzBuzz,
                        Beats = _song.Tempo[fizzBuzz]
                    });
                }
            }

            return noteList;
        }
    }
}
