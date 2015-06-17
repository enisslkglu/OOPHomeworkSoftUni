using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentAndWorker
{
    class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw  new ArgumentNullException("Faculty number cannot be empty!");
                }
                this.facultyNumber = value;
            }
        }

        public Student(string name, string last, string number) : base(name, last)
        {
            this.FacultyNumber = number;
        }

    }
}
