using System;

namespace MusicalFizzBuzz.Library
{
    public class FizzBuzzEngine
    {
        public string Process(int inputNumber)
        {
            if (inputNumber % 5 == 0 &&
                inputNumber % 3 == 0)
            {
                return "FizzBuzz";
            }
            if (inputNumber % 5 == 0)
            {
                return "Buzz";
            }
            if (inputNumber % 3 == 0)
            {
                return "Fizz";
            }

            return inputNumber.ToString();
        }
    }
}
