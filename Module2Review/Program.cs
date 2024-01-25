using System;
namespace Module2Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Student> students = new List<Student>();

            students.Add(new Student("John", 785698));
            students.Add(new Student("Jenny", 721935)); 
            students.Add(new Student("Joseph", 714826)); 
            students.Add(new Student("Joan", 734985));

            foreach(Student student in students)
            {
                student.AddGrade(random.NextDouble() * 100);
                student.AddGrade(random.NextDouble() * 100);
            }
            Console.WriteLine("-------------------------------");
            foreach(Student student in students)
            {
                student.DisplayInfo();
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
