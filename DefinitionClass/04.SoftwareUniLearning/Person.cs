using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string first, string last, int ageInput)
        {
            this.firstName = first;
            this.lastName = last;
            this.age = ageInput;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                try
                {
                    if (Regex.IsMatch(value, @"^[A-z]+(\s?-?)[A-z]+$"))
                    {
                        this.firstName = value;
                    }
                    else
                    {
                        throw new ArgumentException("Name should be with valid letters!!!");
                    }
                }
                catch (ArgumentException arg)
                {
                    Console.WriteLine("Invalid first name" + arg);
                    Environment.Exit(0);

                }
                catch (RegexMatchTimeoutException reg)
                {
                    Console.WriteLine("RegexMatchTimeoutException");
                    Environment.Exit(0);
                }
                
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                try
                {
                    if (Regex.IsMatch(value, @"^[A-z]+(\s?-?)[A-z]+$"))
                    {
                        this.firstName = value;
                    }
                }
                catch (ArgumentException arg)
                {
                    Console.WriteLine("Invalid lastname!!!" + arg);
                    Environment.Exit(0);
                }
                catch (RegexMatchTimeoutException regx)
                {
                    Environment.Exit(0);
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            private set {
                if (value < 0 && value > 150)
                {
                    throw  new ArgumentOutOfRangeException("Age cannot be negative and cannot be bigger than \"150\"!!!");
                }
                this.age = value;
            }
        }
    }
}
