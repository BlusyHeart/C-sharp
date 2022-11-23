using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    internal class Person
    {
        private string name;

        private decimal money;

        public List<Product> BagOfProducts { get; private set; }

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.BagOfProducts = new List<Product>();
        }

        public decimal Money
        {
            get
            {
                return money;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Money cannot be negative");
                }
                money = value;
            }
        }


        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                name = value;
            }
        }

        public void AddProduct(Product product)
        {
            BagOfProducts.Add(product);
            Money -= product.Cost;
        }
    }
}
