using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Dictionary<string, Dictionary<string, List<string>>> atlas = new Dictionary<string, Dictionary<string, List<string>>>();

        int numberOfInputs = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfInputs; i++)
        {
            string continent, country, town;
            ReadInput(out continent, out country, out town);
            AddContinent(atlas, continent);
            AddCountry(atlas, continent, country);

            atlas[continent][country].Add(town);
        }

        PrintAtlas(atlas);
    }

    private static void ReadInput(out string continent, out string country, out string town)
    {
        string[] input = Console.ReadLine().Split();
        continent = input[0];
        country = input[1];
        town = input[2];
    }

    private static void PrintAtlas(Dictionary<string, Dictionary<string, List<string>>> atlas)
    {
        foreach (KeyValuePair<string, Dictionary<string, List<string>>> continent in atlas)
        {
            Console.WriteLine($"{continent.Key}:");
            foreach (KeyValuePair<string, List<string>> country in continent.Value)
            {
                Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
            }
        }
    }

    private static void AddCountry(Dictionary<string, Dictionary<string, List<string>>> atlas, string continent, string country)
    {
        if (!atlas[continent].ContainsKey(country))
        {
            atlas[continent].Add(country, new List<string>());
        }
    }

    private static void AddContinent(Dictionary<string, Dictionary<string, List<string>>> atlas, string continent)
    {
        if (!atlas.ContainsKey(continent))
        {
            atlas.Add(continent, new Dictionary<string, List<string>>());
        }
    }
}
