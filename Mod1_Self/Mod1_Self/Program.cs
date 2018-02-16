using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Self
{
    class Program
    {
        static void Main(string[] args)
        {
            UProgram uProgram = new UProgram("Information Technology");
            Degree bachelor = new Degree("Bachelor of Science: Computer Science");
            uProgram.AddDegree(bachelor);
            Course course = new Course("Programming with C#", 0.5);
            bachelor.AddCourse(course);
            Student student1 = new Student("John", "Doe");
            Student student2 = new Student("Jane", "Jones");
            Student student3 = new Student("Bob", "Smith");
            course.AddStudent(student1);
            course.AddStudent(student2);
            course.AddStudent(student3);
            student1.AddCourse(course);
            student2.AddCourse(course);
            student3.AddCourse(course);
            Teacher teacher = new Teacher("Alan", "Turing");
            course.AddTeacher(teacher);
            teacher.AddCourse(course);

            Console.WriteLine("The Program is {0} and its degrees are:", uProgram.ProgramName);
            foreach(Degree d in uProgram.Degrees) Console.WriteLine("\t {0}", d.DegreeName);
            Console.WriteLine();
            Console.WriteLine("The first degree is {0} and its available courses are:", bachelor.DegreeName);
            foreach(Course c in bachelor.AvailableCourses) Console.WriteLine("\t {0}", c.CourseName);
            Console.WriteLine();
            Console.WriteLine("Total number of students: {0}", Student.StudentCount);
        }
    }
}
