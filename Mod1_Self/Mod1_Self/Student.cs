using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Self
{
    class Student
    {
        private static int studentCount = 0;

        private string firstName;
        private string lastName;
        private List<Course> courses = new List<Course>();

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        internal List<Course> Courses { get => courses; set => courses = value; }
        public static int StudentCount { get => studentCount; }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            studentCount++;
        }
        public Student(string firstName, string lastName, List<Course> courses)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Courses = courses;
            studentCount++;
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }
    }
}
