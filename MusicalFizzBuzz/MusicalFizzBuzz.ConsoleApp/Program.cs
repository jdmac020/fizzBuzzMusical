using MusicalFizzBuzz.Library;
using MusicalFizzBuzz.Library.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static MusicalFizzBuzz.Library.Globals;

namespace MusicalFizzBuzz.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            var beat = 250;
            var song = new Song
            {
                Name = "Axel F",
                Tempo = new Dictionary<string, int>
                {
                    { Notes.FIZZ, 1 },
                    { Notes.BUZZ, 2 },
                    { Notes.FIZZ_BUZZ, 4 },
                    { Notes.REST, 1 }
                }
            };
            var inputs = new int[]
            {
                5,3,2,3,3,3,3,3,
                5,3,2,3,3,3,3,3,
                3,3,3,3,3,15,
                2,2,2,2,2,
                5,3,2,3,3,3,3,3,
                5,3,2,3,3,3,3,3,
                3,3,3,3,3,15,
                2,2,2,2,2,2
            };
            var songPlayer = new SongPlayer(song);

            var output = songPlayer.Play(inputs);

            Console.WriteLine("Press any key to start:");
            Console.ReadLine();
            Thread.Sleep(100);

            var count = 0;
            foreach (var note in output)
            {
                if (note.GetType() != typeof(Rest))
                {
                    if (!note.Value.Equals(Notes.FIZZ))
                    {
                        if (count > 0)
                        {
                            Console.WriteLine();
                            count++;
                        }
                        
                        Console.WriteLine(note.Value);
                    }
                    else
                    {
                        Console.Write(note.Value);
                    }
                }

                Thread.Sleep(note.Beats * beat);
            }

            Console.WriteLine();
            Console.WriteLine("Wah cha cha...");
            Console.ReadLine();
        }
    }
}
