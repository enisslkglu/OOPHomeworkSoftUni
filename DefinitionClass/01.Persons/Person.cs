using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;



class Person
{

    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email) : this (name, age)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age) 
    {
        this.Name = name;
        this.Age = age;
        
    }
    
    public string Name
    {

        get { return this.name; }
        set { if (value != null) this.name = CheckForThrow(value); }
    }

    private string CheckForThrow(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException("Name","Name cannot be null or empty!!!");
        }
        return value;
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value > 100 || value < 0)
            {
                throw new ArgumentOutOfRangeException("Age cannot be smaller than \"0" + "\" or bigger than \"100\"");
            }
            this.age = value;
        }
    }

    public string Email
    {
        get { return this.email; }
        set { this.email = value; }
    }
    

    public override string ToString()
    {
        if (Email.Contains("@"))
        {
            return string.Format("Name: {0}\nAge: {1}\nEmail: {2}", this.Name, this.Age, this.Email);
        }
        else
        {
            return string.Format("Name: {0}\nAge: {1}", this.Name, this.Age);
        }
    }
}

