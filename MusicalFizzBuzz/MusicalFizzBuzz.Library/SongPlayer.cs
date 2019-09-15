using MusicalFizzBuzz.Library.Dto;
using System.Collections.Generic;
using static MusicalFizzBuzz.Library.Globals;

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
                    noteName = Notes.REST;
                }

                noteList.Add(NoteFactory(noteName));
            }

            return noteList;
        }

        private Note NoteFactory(string noteName)
        {
            var beats = _song.Tempo[noteName];

            switch (noteName)
            {
                case Notes.REST:
                    return new Rest(beats);
                default:
                    return new Note
                    {
                        Value = noteName,
                        Beats = beats
                    };
            }
        }
    }
}
