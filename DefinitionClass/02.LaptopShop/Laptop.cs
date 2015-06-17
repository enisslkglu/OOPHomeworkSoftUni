using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


class Laptop
{
    private string Model;
    private string Manufacturer;
    private string Processor;
    private int Ram;
    private string GraphicCard;
    private string Hdd;
    private string Screen;
    private decimal Price;
    public _Battery batteryInfo;


    public Laptop(string model, decimal price)
    {
        this.Model = model;
        this.Price = price;
    }
    public Laptop(
        string model, 
        string manufacturer, 
        string processor,
        int ram,
        string graphicCard,
        string hdd,
        string screen,
        _Battery battery,
        decimal price
        )
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicCard = graphicCard;
        this.Hdd = hdd;
        this.Screen = screen;
        this.batteryInfo = battery;
        this.Price = price;
    }
    public Laptop()
    {

    }
    public string model 
    {
        get { return this.Model; }
        set 
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Model", "Model of laptop cannot be empty or null!!!");
            }
            
            this.Model = value;
        } 
    }

    public decimal price
    {
        get { return this.Price; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Price","Price cannot be negative");
            }
            this.Price = value; 
        }
    }

    public string manufacturer 
    {
        get { return this.Manufacturer; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw  new ArgumentNullException("Manufacturer cannot be empty or null!");
            }
            this.Manufacturer = value;
        } 
    }
    public string processor
    {
        get { return this.Processor; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Processor cannot be empty or null!");
            }
            this.Processor = value;
        }
        
    }
    public int ram
    {
        get { return this.Ram; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("RAM cannot be smaller than \"0\"");
            }
            this.Ram = value;
        }
    }

    public string graphicCard
    {
        get { return this.GraphicCard; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Graphics Card cannot be empty or null!");
            }
            this.GraphicCard = value;
        }
    }

    public string hdd
    {
        get { return this.Hdd; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("HDD cannot be empty or null!");
            }
            this.Hdd = value;
        }
    }

    public string screen
    {
        get { return this.Screen; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Screen cannot be empty or null!");
            }
            this.Screen = value;
        }
    }

    public _Battery Battery
    {
        get { return this.batteryInfo; }
        set { this.batteryInfo = value; }
    }

    public override string ToString()
    {
       StringBuilder result = new StringBuilder();
        result.AppendLine("Sample laptop description: ");
        result.AppendLine("Model: " + this.model);
        if (Manufacturer != null)
        {
            result.AppendLine("Manufacturer: " + this.manufacturer);
        }
        if (Processor != null)
        {
            result.AppendLine("Processor: " + this.processor);
        }
        if (Ram > 0)
        {
            result.AppendLine("RAM: " + this.ram + "GB");
        }
        if (GraphicCard != null)
        {
            result.AppendLine("Graphics card: " + this.graphicCard);
        }
        if (Hdd != null)
        {
            result.AppendLine("HDD: " + this.hdd);
        }
        if (Screen != null)
        {
            result.AppendLine("Screen: " + this.screen);
        }
        if (batteryInfo.battery != null)
        {
            result.AppendLine("Battery: " + this.batteryInfo.battery);
        }
        if (batteryInfo.batteryLife > 0)
        {
            result.AppendLine("Battery life: " + this.batteryInfo.batteryLife + " hours");
        }
        result.AppendLine("Price: " + this.price + "lv.");
        return result.ToString();
    }
}

