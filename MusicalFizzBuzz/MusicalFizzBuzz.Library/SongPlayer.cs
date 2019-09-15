using MusicalFizzBuzz.Library.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicalFizzBuzz.Library
{
    public class SongPlayer
    {
        private FizzBuzzEngine _fizzBuzz;

        public SongPlayer()
        {
            _fizzBuzz = new FizzBuzzEngine();
        }

        public IEnumerable<Note> Play(int[] noteInputs)
        {
            return noteInputs.
                Select(note => 
                    new Note
                    {
                        Value = _fizzBuzz.Process(note)
                    })
                .ToList();
        }
    }
}
