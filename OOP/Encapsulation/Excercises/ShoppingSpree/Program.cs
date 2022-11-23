using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            string[] input = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            string[] productInfo = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {

                for (int i = 0; i < input.Length - 1; i += 2)
                {
                    string productName = productInfo[i];
                    decimal productCost = decimal.Parse(productInfo[i + 1]);
                    Product product = new Product(productName, productCost);
                    products.Add(product);

                    string personName = input[i];
                    decimal money = decimal.Parse(input[i + 1]);
                    Person person = new Person(personName, money);
                    persons.Add(person);
                }

                while (true)
                {
                    string[] offer = Console.ReadLine().Split();
                    if (offer[0] == "END")
                    {
                        break;
                    }

                    string personName = offer[0];
                    string productToBuy = offer[1];
                    bool isBought = false;

                    foreach (Person person in persons)
                    {
                        foreach (Product product in products)
                        {
                            if (person.Name == personName && product.Name == productToBuy)
                            {
                                if (person.Money >= product.Cost)
                                {
                                    person.AddProduct(product);

                                    Console.WriteLine($"{person.Name} bought {product.Name}");
                                    isBought = true;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                                }
                            }
                        }
                        if (isBought == true)
                        {
                            break;
                        }
                    }
                }

                foreach (Person person in persons)
                {
                    if (person.BagOfProducts.Count == 0)
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts.Select(x => x.Name))}");
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
