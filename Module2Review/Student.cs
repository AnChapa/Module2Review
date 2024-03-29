﻿using System;
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

        public Student(string name, int id)
        {
            Name = name;
            Id = id;
            Grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }

        public double CalculateAverageGrades()
        {
            if(Grades.Count == 0) 
                return 0;
            return Grades.Average();
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student: {Name}\nStudent ID: {Id}\nStudent Grade Average: {CalculateAverageGrades()}");
        }
    }
}
