using System;
using System.Linq;
using System.Collections.Generic;

class SongsQueue
{
    static void Main()
    {
        string[] songs = Console.ReadLine().Split(", ");

        Queue<string> songsQueue = new Queue<string>(songs);

        while (songsQueue.Count > 0)
        {
            string command = Console.ReadLine();

            if (command == "Play")
            {
                songsQueue.Dequeue();
            }
            else if (command.Contains("Add"))
            {
                string songName = command.Split("Add ")[1];

                if (songsQueue.Contains(songName))
                {
                    Console.WriteLine($"{songName} is already contained!");
                    continue;
                }
                songsQueue.Enqueue(songName);
            }
            else if (command == "Show")
            {
                Console.WriteLine(string.Join(", ", songsQueue));
            }
        }
        Console.WriteLine("No more songs!");

    }
}
