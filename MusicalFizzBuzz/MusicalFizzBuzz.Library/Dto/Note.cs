namespace MusicalFizzBuzz.Library.Dto
{
    public class Note
    {
        public string Value { get; internal set; }
        public int Beats { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
