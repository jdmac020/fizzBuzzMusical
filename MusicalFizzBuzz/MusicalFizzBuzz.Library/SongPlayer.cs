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
                var noteName = _fizzBuzz.Process(note);

                if (int.TryParse(noteName,out int i))
                {
                    noteName = "Rest";
                }

                noteList.Add(NoteFactory(noteName));
            }

            return noteList;
        }

        private Note NoteFactory(string noteName)
        {
            var beats = GetBeats(noteName);

            switch (noteName)
            {
                case "Rest":
                    return new Rest(beats);
                default:
                    return new Note
                    {
                        Value = noteName,
                        Beats = beats
                    };
            }
        }

        private int GetBeats(string noteName = "Rest")
        {
            return _song.Tempo[noteName];
        }
    }
}
