using System;
using System.Collections.Generic;
using System.Text;

namespace MusicalFizzBuzz.Library.Dto
{
    public class Note
    {
        public string Value { get; internal set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
