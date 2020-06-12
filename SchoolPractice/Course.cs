using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public List<Student> enrolledStudents = new List<Student>();
        public string CourseTitle { get; set; }
        public string Location { get; set; }
        public Teacher Instructor { get; set; }

        public Course(List<Student> enrolledStudents, string title, string location, Teacher instructor );
        {
        }
    }
}
