using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.Trainer
{
    class JuniorTrainer : Trainer
    {
        public JuniorTrainer(string first, string last, int ageInput) : base(first, last, ageInput)
        {
        }

        public override string ToString()
        {
            string result = "Junior Trainer:";
            result = result + base.FirstName + " " + base.LastName + " " + "\nAge" + base.Age;
            return result;
        }
    }
}
