using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace TilesMaster
{
    class Training
    {
        static void Main()
        {
            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> greyTiles = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Dictionary<string, int> locations = new Dictionary<string, int>()
            {
                {"Sink", 40},
                {"Oven", 50},
                {"Countertop", 60},
                {"Wall", 70},
            };

            Dictionary<string, int> tilesTracker = new Dictionary<string, int>();

            while (greyTiles.Count != 0 && whiteTiles.Count != 0)
            {
                int currentGreyTileArea = greyTiles.Peek();
                int currentWhiteTileArea = whiteTiles.Peek();
                bool isMatch = false;

                if (currentGreyTileArea == currentWhiteTileArea)
                { 
                    int sumTilesArea = currentGreyTileArea + currentWhiteTileArea;
                   
                    foreach (KeyValuePair <string, int> location in locations)
                    {
                        if (location.Value == sumTilesArea)
                        {
                            if (!(tilesTracker.ContainsKey(location.Key)))
                            {
                                tilesTracker.Add(location.Key, 0);
                            }
                            tilesTracker[location.Key] ++;
                            isMatch = true;
                        }
                        if (isMatch)
                        {
                            break;
                        }
                    }
                    if (!isMatch)
                    {
                        if (!tilesTracker.ContainsKey("Floor"))
                        {
                            tilesTracker.Add("Floor", 0);
                        }
                        tilesTracker["Floor"]++;
                    }
                    greyTiles.Dequeue();
                    whiteTiles.Pop();
                }
                else
                {
                    whiteTiles.Push(whiteTiles.Pop() / 2);
                    greyTiles.Enqueue(greyTiles.Dequeue());
                }
            }

            if (whiteTiles.Count > 0)
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTiles)}");
            }
            else
            {
                Console.WriteLine("White tiles left: none");
            }

            if (greyTiles.Count > 0)
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
            }
            else
            {
                Console.WriteLine("Grey tiles left: none");
            }

            Dictionary<string, int> sortedLocations = 
                 tilesTracker
                .OrderByDescending(l => l.Value)
                .ThenBy(l => l.Key)
                .ToDictionary(l => l.Key, l => l.Value);


            foreach (KeyValuePair <string, int> location in sortedLocations)
            {
                Console.WriteLine($"{location.Key}: {location.Value}");
            }
        }
    }
}
