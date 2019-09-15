using System;
using System.Collections.Generic;
using System.Text;

namespace MusicalFizzBuzz.Library.Dto
{
    public class Song
    {
        public string Name { get; set; }
        public Dictionary<string, int> Tempo { get; set; }
    }
}
