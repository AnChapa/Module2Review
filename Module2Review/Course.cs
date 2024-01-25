using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Review
{
    internal class Course
    {
        public string CourseName {  get; set; }
        public string CourseCode { get; set; }
        public List<Student> EnrolledStudents;

        public Course(string courseName, string courseCode) 
        {
            CourseName = courseName;
            CourseCode = courseCode;
            EnrolledStudents = new List<Student>();
        }
        public void Enroll(Student student)
        {
            EnrolledStudents.Add(student);
        }
        public List<Student> GetEnrolledStudents()
        {
            return EnrolledStudents;
        }
        public string GetCourseName()
        {
            return CourseName;
        }
        public string GetCourseCode()
        {
            return CourseCode;
        }
    }
}
