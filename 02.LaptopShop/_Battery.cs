using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _Battery
{
    private string Battery;
    private double BatteryLife;
    public _Battery(string battery, double batteryLife)
    {
        this.Battery = battery;
        this.BatteryLife = batteryLife;
    }

    public _Battery(string battery)
    {
        this.Battery = battery;
    }

    public _Battery(double batteryLife)
    {
        this.BatteryLife = batteryLife;
    }

    public _Battery()
    {

    }
    public string battery
    {
        get { return this.Battery; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Battery cannot be empty or null!");
            }
            this.Battery = value;
        }

    }
    public double batteryLife
    {
        get { return this.BatteryLife; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Battery life cannot be smaller than \"0\"");
            }
            this.BatteryLife = value;
        }
    }

    
}

