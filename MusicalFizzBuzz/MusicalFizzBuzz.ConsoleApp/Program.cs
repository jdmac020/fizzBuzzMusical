using MusicalFizzBuzz.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MusicalFizzBuzz.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            var fizzBuzz = new FizzBuzzEngine();

            var inputs = Enumerable.Range(0, 500);

            foreach (var input in inputs)
            {
                var result = fizzBuzz.Process(input);

                if (int.TryParse(result, out int intVar) == false)
                {
                    if (result == "FizzBuzz")
                    {
                        Console.WriteLine(result);
                        Thread.Sleep(300);
                    }
                    if (result == "Buzz")
                    {
                        Console.Write($"{result} ");
                        Thread.Sleep(250);
                    }
                    if (result == "Fizz")
                    {
                        Console.Write($"{result} ");
                        Thread.Sleep(100);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
