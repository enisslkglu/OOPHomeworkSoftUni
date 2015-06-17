using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentAndWorker
{
    class MainProgram
    {
        private static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", "132ivan123"),
                new Student("Diana", "Georgieva", "143diana143"),
                new Student("Petyr", "Petrov", "999petrov999"),
                new Student("Boyko", "Plamenov", "823boyko823"),
                new Student("Mariya", "Marinov", "845mariya343"),
                new Student("Plamena", "Antonov", "333plamena444"),
                new Student("Anna", "Grigorov", "576anna384"),
                new Student("Bojidar", "Bojidarov", "232bojidar432"),
                new Student("Yavor", "Georgiev", "232yavor534"),
                new Student("Martin", "Martinov", "745martin856"),
            };

            students = new List<Student>(students.OrderBy(s => s.FacultyNumber));

            List<Worker> workers = new List<Worker>();
            while (workers.Count < 10)
            {
                workers.Add(new Worker(Console.ReadLine(), Console.ReadLine(), decimal.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            }

            workers = new List<Worker>(workers.OrderBy(m => m.MoneyPerHour()));
            
            List<Human> result = new List<Human>();
            students.ForEach(stud => result.Add(stud));
            workers.ForEach(wor => result.Add(wor));
            result = new List<Human>(result.OrderBy(r => r.FirstName));

            foreach (Human human in result)
            {
                Console.WriteLine("{0} {1} ({2})",human.FirstName, human.LastName, human.GetType().Name);
            }
        }
    }
}
