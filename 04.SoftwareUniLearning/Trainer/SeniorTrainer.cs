using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.Trainer
{
    class SeniorTrainer : Trainer
    {
       
        public SeniorTrainer(string first, string last, int ageInput) : base(first, last, ageInput)
        {
        }

        public void DeletedCourse(string course)
        {
            if (string.IsNullOrEmpty(course))
            {
                throw  new ArgumentNullException("Invalid course name!!!");
            }
            else if (courses.Contains(course))
            {
                Console.WriteLine("No course");
                return;
            }
            base.courses.Remove(course);
        }

        public override string ToString()
        {
            string result = "Senior Trainer:";
            result = result + base.FirstName + " " + base.LastName + " " + "\nAge" + base.Age;
            return result;
        }
    }
}
