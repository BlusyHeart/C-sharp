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
            AddShopName(shops, shopName);

            string product = data[1];
            double price = double.Parse(data[2]);
            AddProduct(shops, shopName, product, price);
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

    private static void AddProduct(SortedDictionary<string, Dictionary<string, double>> shops, string shopName, string product, double price)
    {
        if (!shops[shopName].ContainsKey(product))
        {
            shops[shopName].Add(product, 0);
        }
        shops[shopName][product] = price;
    }

    private static void AddShopName(SortedDictionary<string, Dictionary<string, double>> shops, string shopName)
    {
        if (!shops.ContainsKey(shopName))
        {
            shops.Add(shopName, new Dictionary<string, double>());
        }
    }
}
