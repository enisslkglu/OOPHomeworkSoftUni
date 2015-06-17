using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentAndWorker
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Lastname cannot be empty!");
                }
                this.lastName = value;
            }
        }

        public Human(string name, string last)
        {
            this.FirstName = name;
            this.LastName = last;
        }

        public override string ToString()
        {
            return String.Format("Full name: {0} {1}",this.FirstName, this.LastName);
        }
    }
}
