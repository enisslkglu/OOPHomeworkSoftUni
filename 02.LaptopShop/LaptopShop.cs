using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LaptopShop
{
    static void Main()
    {
        //RAM is int type. You need to enter just an integer. Not some letter.
        //for price and battery life, you need to write comma, not dot.

        Laptop laptopInfo = new Laptop
        {
            model = Console.ReadLine(),
            manufacturer = Console.ReadLine(),
            processor = Console.ReadLine(),
            ram = int.Parse(Console.ReadLine()),
            graphicCard = Console.ReadLine(),
            hdd = Console.ReadLine(),
            screen = Console.ReadLine(),
            batteryInfo = new _Battery
            {
                battery = Console.ReadLine(),
                batteryLife = double.Parse(Console.ReadLine())
            },
            price = decimal.Parse(Console.ReadLine()),

        };
        
        Console.WriteLine(laptopInfo);
        
    }
}

