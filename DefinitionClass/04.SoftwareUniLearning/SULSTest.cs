using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.SoftwareUniversityLearningSystem.CurrentStudent;
using _04.SoftwareUniversityLearningSystem.Student;
using _04.SoftwareUniversityLearningSystem.Trainer;

namespace _04.SoftwareUniversityLearningSystem
{
    class SULSTest
    {
        static void Main()
        {
            List<object> checkStudents = new List<object>();
            DropoutStudent andrea = new DropoutStudent("Andrea","Andreov",25,4.34,"30075684724","Grade is not enought.");
            SeniorTrainer filip = new SeniorTrainer("Filip","Kolev",26);
            JuniorTrainer anna = new JuniorTrainer("Anna", "Ushakova", 22);
            GraduateStudent blago = new GraduateStudent("Blago","Vladimir",30,6.00,"3002237644");
            OnlineStudent john = new OnlineStudent("John", "Smith", 35, 3.56, "300234567", "OOP");
            OnsiteStudent vanka = new OnsiteStudent("Ivan", "Ivanov", 24, 4.70, "300987654",
                "CSharp - Programming Basic", 4);
            OnsiteStudent diana = new OnsiteStudent("Diana","Dianova",22,5.45,"300745123","OOP",6);
            OnlineStudent mars = new OnlineStudent("Mars","Gorbachov",26,4.45,"302345324","CSharp Fundamental Level");
            OnlineStudent mariq = new OnlineStudent("Maria","Georgieva",28,3.45,"300323343","PHP");
            OnsiteStudent plamen = new OnsiteStudent("Plamen Ivailo","Georgiev", 30, 4.89,"304345345","Java",3);
            checkStudents.Add(andrea);
            checkStudents.Add(filip);
            checkStudents.Add(anna);
            checkStudents.Add(blago);
            checkStudents.Add(john);
            checkStudents.Add(vanka);
            checkStudents.Add(diana);
            checkStudents.Add(mars);
            checkStudents.Add(mariq);
            checkStudents.Add(plamen);

            List<object> sorted = checkStudents
                .Where(x => x.GetType().BaseType == typeof (Student.CurrentStudent)).ToList();

            List<Student.CurrentStudent> sortStudents = sorted.Cast<Student.CurrentStudent>().ToList();
            sortStudents = sortStudents.OrderBy(x => x.AverageGrade).ToList();
            foreach (var student in sortStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
