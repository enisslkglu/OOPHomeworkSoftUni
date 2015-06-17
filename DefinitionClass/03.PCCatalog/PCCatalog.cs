using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PCCatalog
{
    class PCCatalog
    {
        static void Main(string[] args)
        {
            List<Computer> pcKatalog = new List<Computer>();
            List<Component> components = new List<Component>();
            components.Add(new Component("RAM", 123.50m));
            components.Add(new Component("HDD", 250m, "128GB SSD"));
            components.Add(new Component("Screen", 300.50m, "13.3 \"(33.78 cm)-3200x1800 (QHD+),IPS sensor display"));
            Computer lenovo = new Computer("Lenovo",components);

            
            List<Component> components2 = new List<Component>();
            components2.Add(new Component("RAM", 100m, "2GB DDR3L 1600 MHz"));
            components2.Add(new Component("HDD", 149.99m, "500GB 5400rpm SATA"));
            components2.Add(new Component("Graphics card", 168m, "Intel HD Graphics"));
            components2.Add(new Component("Processor", 200m, "Intel Celeron 2-core N2840 2.16GHz/2.58GHz"));
            Computer lenovo2 = new Computer("LenovoG50-30", components2);

            pcKatalog.Add(lenovo);
            pcKatalog.Add(lenovo2);
            var sortedPrice = pcKatalog.OrderBy(laptop => laptop.Price);
            foreach (var laptop in pcKatalog)
            {
                Console.WriteLine(laptop);
            }
        }
    }
}
