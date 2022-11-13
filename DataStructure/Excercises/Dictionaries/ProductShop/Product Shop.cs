using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Revision")
            {
                break;
            }

            string[] data = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string shopName = data[0];
            AddShop(shops, shopName);   
            
            string product = data[1];
            double price = double.Parse(data[2]);
            shops[shopName].Add(product, price);
        }
        PrintShopDetails(shops);
    }

    private static void PrintShopDetails(SortedDictionary<string, Dictionary<string, double>> shops)
    {
        foreach (KeyValuePair<string, Dictionary<string, double>> shop in shops)
        {
            Console.WriteLine($"{shop.Key}->");
            foreach (KeyValuePair<string, double> product in shop.Value)
            {
                Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
            }
        }
    }
    private static void AddShop(SortedDictionary<string, Dictionary<string, double>> shops, string shopName)
    {
        if (!shops.ContainsKey(shopName))
        {
            shops.Add(shopName, new Dictionary<string, double>());
        }
    }
}
