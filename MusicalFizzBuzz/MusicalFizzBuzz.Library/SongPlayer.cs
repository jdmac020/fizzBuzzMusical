using MusicalFizzBuzz.Library.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicalFizzBuzz.Library
{
    public class SongPlayer
    {
        public IEnumerable<Note> Play()
        {
            return new List<Note>();
        }

        public IEnumerable<Note> Play(int[] noteInputs)
        {
            return noteInputs.Select(note => new Note()).ToList();
        }
    }
}
