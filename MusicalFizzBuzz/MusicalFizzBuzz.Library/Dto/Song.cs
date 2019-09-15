using System.Collections.Generic;

namespace MusicalFizzBuzz.Library.Dto
{
    public class Song
    {
        public string Name { get; set; }
        public Dictionary<string, int> Tempo { get; set; }
    }
}
