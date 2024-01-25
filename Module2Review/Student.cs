using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Review
{
    internal class Student
    {
        private string Name {  get; set; }
        private int Id { get; set; }
        private List<double> Grades { get; set; }

        public Student()
        {
            Grades = new List<double>();
        }

    }
}
