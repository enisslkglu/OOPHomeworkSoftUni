using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentAndWorker
{
    class Worker:Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary is negative!");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("Hours cannot be negative or bigger than 24!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal perHour = (this.WeekSalary/5)/this.WorkHoursPerDay;
            return perHour;
        }

        public Worker(string name, string last, decimal salary, int hours) : base(name, last)
        {
            
            this.WeekSalary = salary;
            this.WorkHoursPerDay = hours;
        }

        public override string ToString()
        {
            return string.Format("{0}, Week salary: {1}, Works hour per day: {2}, Money per hour: {3}",
                base.ToString(),this.WeekSalary,this.WorkHoursPerDay,this.WorkHoursPerDay);
        }
    }
}
