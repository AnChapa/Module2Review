using System;
namespace Module2Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Course coding = new Course("Coding in C#", random.Next(100000, 999999).ToString());

            coding.Enroll(new Student("John", random.Next(100000, 999999)));
            coding.Enroll(new Student("Jenny", random.Next(100000, 999999)));
            coding.Enroll(new Student("Joseph", random.Next(100000, 999999)));
            coding.Enroll(new Student("Joan", random.Next(100000, 999999)));

            foreach(Student student in coding.GetEnrolledStudents())
            {
                student.AddGrade(random.NextDouble() * 100);
                student.AddGrade(random.NextDouble() * 100);
                
            }
            Console.WriteLine($"Class: {coding.GetCourseName()}\nClass ID: {coding.GetCourseCode()}\nStudents Enrolled:");
            Console.WriteLine("-------------------------------");
            foreach(Student student in coding.GetEnrolledStudents())
            {
                student.DisplayInfo();
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
