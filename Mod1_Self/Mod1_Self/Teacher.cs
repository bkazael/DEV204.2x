using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Self
{
    class Teacher
    {
        private string firstName;
        private string lastName;
        private List<Course> courses = new List<Course>();

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        internal List<Course> Courses { get => courses; set => courses = value; }

        public Teacher(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Teacher(string firstName, string lastName, List<Course> courses)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Courses = courses;
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }
    }
}
