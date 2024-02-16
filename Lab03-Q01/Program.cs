//Design a C# class named Course that encapsulates information about a student's course and demonstrates proper use of access specifiers and properties.
//The class should have the following:
//	○ Private fields for courseName, instructorName, and grade (double between 0 and 100)
//	○ ﻿﻿Public properties for CourseName (read-only) and Grade (read-only) with validation (throw extensions for invalid data)
//	○ ﻿﻿A public method SetInstructorName to set the instructor's name with validation (empty strings not allowed).
//	○ ﻿﻿A private method CalculateLetterGrade to calculate the letter grade based on the grade (A-F) and return it as a string.
//	○ A public method PrintCourseInfo that displays the course name, instructor name, and letter grade without revealing the actual numeric grade



using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Q01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            course.SetCouseName("Data Communication and Networking");
            course.SetInstructorName("Madhusanka Mithrananda");
            course.Grade = 78;
            course.PrintCourseInfo();

        }
    }
    class Course
    {
        private string courseName;
        private string instructorName;
        private double grade;

        public string CourseName
        {
            get { return courseName; }
        }
        public string InstructorName
        {
            get { return instructorName; }
        }
        public double Grade
        {
            get { return grade; }
            set
            {
                if (value <= 100 && value >= 0)
                {
                    grade = value;
                }
                else
                {
                    Console.WriteLine("Invalid Grade Value!");
                }
            }
        }
        public void SetInstructorName(string instructorName)
        {
            if (!string.IsNullOrWhiteSpace(instructorName))
            {
                this.instructorName = instructorName;
            }
            else
            {
                Console.WriteLine("Instructor Name cannot be empty!");
            }
        }
        public void SetCouseName(string courseName)
        {
            if (!string.IsNullOrWhiteSpace(courseName))
            {
                this.courseName = courseName;
            }
            else
            {
                Console.WriteLine("Course Name cannot be empty!");
            }
        }
        private string CalculateLetterGrade()
        {
            if (grade >= 75)
            {
                return "A";
            }
            else if (grade >= 60)
            {
                return "B";
            }
            else if (grade >= 50)
            {
                return "C";
            }
            else if (grade >= 40)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        public void PrintCourseInfo()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Instructor Name: {InstructorName}");
            Console.WriteLine($"Grade Letter: {CalculateLetterGrade()}");
        }
    }
}