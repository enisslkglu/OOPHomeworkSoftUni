using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.Student
{
    public abstract class CurrentStudent : Student
    {
        private string currentCourse;
        public CurrentStudent(string first, string last, int age, double avgGrade, string studentNum, string course) : base(first, last, age, avgGrade, studentNum)
        {
            this.CurrentCourse = course;
        }

        public string CurrentCourse
        {
            get { return this.currentCourse; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid course name!!!");
                }
                this.currentCourse = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Current course: " + this.CurrentCourse + "Student status: Current student.";
        }
    }
}
