using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Self
{
    class Degree
    {
        private string degreeName;
        private double creditsRequired;
        private List<Course> availableCourses = new List<Course>();

        public string DegreeName { get => degreeName; set => degreeName = value; }
        public double CreditsRequired { get => creditsRequired; set => creditsRequired = value; }
        internal List<Course> AvailableCourses { get => availableCourses; set => availableCourses = value; }

        public Degree(string degreeName)
        {
            this.DegreeName = degreeName;
        }
        public Degree(string degreeName, double creditsRequired)
        {
            this.DegreeName = degreeName;
            this.CreditsRequired = creditsRequired;
        }
        public Degree(string degreeName, double creditsRequired, List<Course> availableCourses)
        {
            this.DegreeName = degreeName;
            this.CreditsRequired = creditsRequired;
            this.AvailableCourses = availableCourses;
        }

        public void AddCourse(Course course)
        {
            AvailableCourses.Add(course);
        }
    }
}
