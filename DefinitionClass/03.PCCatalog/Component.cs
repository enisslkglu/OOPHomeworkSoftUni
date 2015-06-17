using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _03.PCCatalog
{
    class Component
    {
        private string name;
        private decimal price;
        private string details;
        private string p1;
        private double p2;
        private string p3;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw  new ArgumentNullException("Name cannt be empty or null!!!");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw  new ArgumentOutOfRangeException("Price cannot be negative!!!");
                }
                this.price = value;
            }
        }

        public string Details { get; set; }

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Component(string name, decimal price, string details) : this(name, price)
        {
            this.Details = details;
        }


    }
}
