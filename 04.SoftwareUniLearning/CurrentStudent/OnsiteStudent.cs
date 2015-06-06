using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.CurrentStudent
{
    class OnsiteStudent : Student.CurrentStudent
    {
        private int numberOfVisit;
        public OnsiteStudent(string first, string last, int age, double avgGrade, string studentNum, string course, int visits) : base(first, last, age, avgGrade, studentNum, course)
        {
            this.NumberVisits = visits;
        }

        public int NumberVisits
        {
            get { return this.numberOfVisit; }
            private set {
                if (Regex.IsMatch(value.ToString().Trim(), "^[0-9]$"))
                {
                    this.numberOfVisit = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Onsite Student");
            result.AppendLine(string.Format("Number of visit: {0}", this.NumberVisits));
            return base.ToString() + result;
        }
    }
}
