using System;

namespace MusicalFizzBuzz.Library
{
    public class FizzBuzzEngine
    {
        public string Process(int inputNumber)
        {
            if (InputIsFactorOf(5, inputNumber) &&
                InputIsFactorOf(3, inputNumber))
            {
                return "FizzBuzz";
            }
            if (InputIsFactorOf(5, inputNumber))
            {
                return "Buzz";
            }
            if (InputIsFactorOf(3,inputNumber))
            {
                return "Fizz";
            }

            return inputNumber.ToString();
        }

        private bool InputIsFactorOf(int factor, int input)
        {
            return input % factor == 0;
        }
    }
}
