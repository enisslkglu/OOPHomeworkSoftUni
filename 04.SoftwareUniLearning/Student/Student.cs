using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.Student
{
    public abstract class Student : Person
    {
        private double averageGrade;
        private string studentNumber;
        protected Student(string first, string last, int age, double avgGrade, string studentNum) : base(first, last, age)
        {
            this.AverageGrade = avgGrade;
            this.StudentNumber = studentNum;
        }

        public string StudentNumber
        {
            get { return this.studentNumber; }
            private set
            {
                if (!Regex.IsMatch(value, "^[0-9]+$" ) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid student number!!!");
                }
                this.studentNumber = value;
            }
        }

        public double AverageGrade
        {
            get { return this.averageGrade; }
            private set {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Grade is not valid!!!");
                }
                else if (Regex.IsMatch(value.ToString().Trim(), @"^[2-6]([.,][0-9]{1,2})?$"))
                {
                    this.averageGrade = value;
                }
                
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("\nStudent");
            result.AppendLine(string.Format("Student name: {0} {1}", base.FirstName, base.LastName));
            result.AppendLine(string.Format("Age: {0}", base.Age));
            result.AppendLine(string.Format("Student number: {0}", this.StudentNumber));
            result.AppendLine(String.Format("Average grade: {0}", this.AverageGrade));
            return result.ToString();
        }
    }
}
