using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // read number of clothes

        int numberOfClothes = int.Parse(Console.ReadLine());

        // initilize nestedSortedDictionary

        Dictionary<string, Dictionary<string, int>> wardrobe =
            new Dictionary<string, Dictionary<string, int>>();

        // read input

        WardrobeManipulator(numberOfClothes, wardrobe);

        // read a color and a cloth to be found

        string[] targetData = Console.ReadLine().Split();
        string targetColor = targetData[0];
        string targetCloth = targetData[1];

        // iterate through every color
        foreach (KeyValuePair<string, Dictionary<string, int>> color in wardrobe)
        {
            // print color
            Console.WriteLine($"{color.Key} clothes:");

            // iteratee through every cloth
            foreach (KeyValuePair<string, int> cloth in color.Value)
            {
                // print cloth but first check if you've found the targetCloth
                if (cloth.Key == targetCloth && color.Key == targetColor)
                {
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                }
                else
                {
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                }
            }

        }

    }

    private static void WardrobeManipulator(int numberOfClothes, Dictionary<string, Dictionary<string, int>> wardrobe)
    {
        for (int index = 0; index < numberOfClothes; index++)
        {
            // split the data for each color

            string[] colorData = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            string[] clothes = colorData[1].Split(",");

            // check if a color exist in our wardrobe
            string color = colorData[0];
            AddColor(wardrobe, color);

            // iterate through clothes
            AddCloth(wardrobe, clothes, color);
        }
    }

    private static void AddCloth(Dictionary<string, Dictionary<string, int>> wardrobe, string[] clothes, string color)
    {
        for (int i = 0; i < clothes.Length; i++)
        {
            string currentCloth = clothes[i];
            // check if our color has this cloth
            if (!wardrobe[color].ContainsKey(currentCloth))
            {
                wardrobe[color].Add(currentCloth, 0);
            }

            // increment counter for every cloth
            wardrobe[color][currentCloth]++;
        }
    }

    private static void AddColor(Dictionary<string, Dictionary<string, int>> wardrobe, string color)
    {
        if (!wardrobe.ContainsKey(color))
        {
            wardrobe.Add(color, new Dictionary<string, int>());
        }
    }
}
