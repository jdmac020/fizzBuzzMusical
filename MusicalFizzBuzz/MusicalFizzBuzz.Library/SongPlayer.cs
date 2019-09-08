using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicalFizzBuzz.Library
{
    public class SongPlayer
    {
        public IEnumerable<string> Play(IEnumerable<int> inputNotes)
        {
            return inputNotes.Select(note => note.ToString());
        }
    }
}
