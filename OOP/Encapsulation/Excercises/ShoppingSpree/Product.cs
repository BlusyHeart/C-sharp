using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    internal class Product
    {
        private string name;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            Cost = cost;
        }

        public decimal Cost { get; set; }

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



    }
}
