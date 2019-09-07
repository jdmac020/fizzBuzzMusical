using System;

namespace MusicalFizzBuzz.Library
{
    public class FizzBuzzEngine
    {
        private int _input;

        public string Process(int inputNumber)
        {
            _input = inputNumber;

            if (InputIsFactorOf(5) &&
                InputIsFactorOf(3))
            {
                return "FizzBuzz";
            }
            if (InputIsFactorOf(5))
            {
                return "Buzz";
            }
            if (InputIsFactorOf(3))
            {
                return "Fizz";
            }

            return _input.ToString();
        }

        private bool InputIsFactorOf(int factor)
        {
            return _input % factor == 0;
        }
    }
}
