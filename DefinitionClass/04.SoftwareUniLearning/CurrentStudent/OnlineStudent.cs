using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.CurrentStudent
{
    class OnlineStudent : Student.CurrentStudent
    {
        public OnlineStudent(string first, string last, int age, double avgGrade, string studentNum, string course) : base(first, last, age, avgGrade, studentNum, course)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "Online student";
        }
    }
}
