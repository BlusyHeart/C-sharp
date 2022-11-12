using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[]args)
    {

        int totalFoodQuantity = int.Parse(Console.ReadLine());

        List<int> sequanceOfOrders = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        Queue<int> orders = new Queue<int>(sequanceOfOrders);
        Console.WriteLine(orders.Max());
        int countOrders = orders.Count;

        for (int i = 1; i <= countOrders; i++)
        {
            if (totalFoodQuantity >= orders.Peek())
            {
                totalFoodQuantity -= orders.Peek();
                orders.Dequeue();
            }
            else
            {
                break;
            }
        }

        if (orders.Count == 0)
        {
            Console.WriteLine("Orders complete");            
        }
        else
        {
            Console.WriteLine($"Orders left: {string.Join("", orders)}");
        }

    }
}
