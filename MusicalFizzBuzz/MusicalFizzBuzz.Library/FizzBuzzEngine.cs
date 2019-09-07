using System;

namespace MusicalFizzBuzz.Library
{
    public class FizzBuzzEngine
    {
        public string Process(int inputNumber)
        {
            if (inputNumber % 3 == 0)
            {
                return "Fizz";
            }

            return inputNumber.ToString();
        }
    }
}
