using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.PCCatalog
{
    class Computer
    {
        private string name;
        private List<Component> components;

        public string Name 
        { 
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!!!");
                }
                this.name = value;
            } 
        }

        public List<Component> Components
        {
            get { return this.components; }
            set
            {
                if (value.Count < 0)
                {
                    throw new ArgumentNullException("Components cannot be empty or null!!!");
                }
                this.components = value;
            }
        }

        public decimal Price { get { return Calculate(this); }}

        private decimal Calculate(Computer computer)
        {
            var component = computer.Components;
            decimal sumPrice = components.Sum(components1 => components1.Price);
            return sumPrice;
        }

        public Computer(string name, List<Component> compopent )
        {
            this.Name = name;
            this.Components = compopent;
        }

        public override string ToString()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg");
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Computer name: {0}", this.Name));
            foreach (var information in components)
            {
                if (!string.IsNullOrWhiteSpace(information.Details))
                {
                    result.AppendLine(string.Format("{0}:{2}: {1:C2}", information.Name, information.Price, information.Details));
                }
                else
                {
                    result.AppendLine(string.Format("{0}:{2} {1:C2}", information.Name, information.Price, information.Details));
                }
            }
            result.AppendLine(string.Format("Total: {0}", this.Price));
            return result.ToString();
        }
    }

}
