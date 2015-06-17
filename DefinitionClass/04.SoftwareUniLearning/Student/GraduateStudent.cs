using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.Student
{
    class GraduateStudent : Student
    {
        public GraduateStudent(string first, string last, int age, double avgGrade, string studentNum) : base(first, last, age, avgGrade, studentNum)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "\nStatus of student: Graduate.";
        }
    }
}
