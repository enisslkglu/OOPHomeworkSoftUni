using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Persons
{
    static void Main()
    {
        var infos = new Person
        {
            Name = Console.ReadLine(),
            Age = int.Parse(Console.ReadLine()),
            Email = Console.ReadLine()
        };
        
        Console.WriteLine(infos);

        
    }
    
}

