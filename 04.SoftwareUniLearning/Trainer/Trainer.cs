using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.Trainer
{
    public abstract class Trainer : Person
    {
        protected List<string> courses; 
        public Trainer(string first, string last, int ageInput) : base(first, last, ageInput)
        {
            courses = new List<string>();
        }

        public void CreatingCourse(string course)
        {
            if (string.IsNullOrEmpty(course))
            {
                throw new ArgumentNullException("Course name cannot be empty or null!!!");
            }
            courses.Add(course);
            Console.WriteLine("Creating course: {0}", course);
        }

        public void DisplayCourse()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("There has no course");
                return;
            }
            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}
