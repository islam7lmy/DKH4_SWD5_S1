using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public double Grade { get; set; }
    }
}
