using QuanLySinhVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var Student = new List<Student> 
            {
                new Student{FirstName="Nguyễn Duy", LastName="Khánh", EnrollmentDate=DateTime.Parse("1987-07-11")},
                new Student{FirstName="Bộ Kinh", LastName="Vân", EnrollmentDate=DateTime.Parse("1992-02-12")},
                new Student{FirstName="Nhiếp", LastName="Phong", EnrollmentDate=DateTime.Parse("1991-08-31")},
                new Student{FirstName="Tuyệt Vô", LastName="Thần", EnrollmentDate=DateTime.Parse("1986-07-07")},
                new Student{FirstName="Vô", LastName="Danh", EnrollmentDate=DateTime.Parse("1992-08-21")}
            };
            Student.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course{CourseId=1,Title="ASP MVC 5",Credits=3},
                new Course{CourseId=2,Title="Java Core",Credits=4},
                new Course{CourseId=3,Title="iOS Apps",Credits=3},
                new Course{CourseId=4,Title="ASP.NET Winform",Credits=5}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentId=1, CourseId=2, Grade=Grade.A},
                new Enrollment{StudentId=2, CourseId=1, Grade=Grade.B},
                new Enrollment{StudentId=3, CourseId=4, Grade=Grade.C},
                new Enrollment{StudentId=4, CourseId=3, Grade=Grade.F},
                new Enrollment{StudentId=5, CourseId=2, Grade=Grade.B}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}