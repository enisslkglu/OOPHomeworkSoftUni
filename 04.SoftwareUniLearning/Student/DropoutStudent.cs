using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.Student
{
    class DropoutStudent : Student
    {
        public string dropoutReasons;
        private string p1;
        private string p2;
        private int p3;
        private int p4;
        private int p5;
        private string p6;
        private string p7;
        public DropoutStudent(string first, string last, int age, double avgGrade, string studentNum,string dropout) : base(first, last, age, avgGrade, studentNum)
        {
            this.Reason = dropout;
        }

        public string Reason
        {
            get { return this.dropoutReasons; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid dropout reasons!!!");
                }
                this.dropoutReasons = value;
            }
        }

        public void Reapply()
        {
            string allInfo = this.ToString();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("\nStatus of student: Drop out!"));
            result.AppendLine(string.Format("Reason of drop out: {0}", this.Reason));
            return base.ToString();
        }
    }
}
