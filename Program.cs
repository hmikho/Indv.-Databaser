using Indv_SchoolDb.Data;
using Indv_SchoolDb.Models;
using System;
using System.Linq;

namespace Indv_SchoolDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolDbContext())
            {
                while (true)
                {
                    Console.WriteLine("----- School Menu -----");
                    Console.WriteLine("1. Show techers per deparment");
                    Console.WriteLine("2. Show all students");
                    Console.WriteLine("3. Show active courses");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Choose an option");

                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            ShowTeacherByDepartment(context);
                            break;
                        case "2":
                            ShowAllStudents(context);
                            break;
                        case "3":
                            ShowActiveCourses(context);
                            break;
                        case "4":
                            return;
                        default:
                            Console.WriteLine("Invalid Option. Try again.");
                            break;

                    }
                }
            }
        }
        static void ShowTeacherByDepartment(SchoolDbContext context)
        {
            var teacherCounts = context.Staffs
                .Where(s => s.Position == "Teacher")
                .GroupBy(s => s.Department.DepartmentName)
                .Select(g => new
                {
                    Department = g.Key,
                    TeacherCount = g.Count()
                })
                .ToList();

            Console.WriteLine("\n--- Teacher Count by Department ---");
            foreach (var item in teacherCounts)
            {
                Console.WriteLine($"Department: {item.Department}, Teachers: {item.TeacherCount}");
            }
            Console.WriteLine();
        }


        static void ShowAllStudents(SchoolDbContext context)
        {
            var students = context.Students.ToList();
            Console.WriteLine("\n--- All Students ---");
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Class: {student.Class}");
            }
            Console.WriteLine();
        }
        static void ShowActiveCourses(SchoolDbContext context)
        {
            var activeCourses = context.Courses
                .Where(c => c.IsActive == true)
                .ToList();

            Console.WriteLine("\n--- Active Courses ---");
            foreach (var course in activeCourses)
            {
                Console.WriteLine($"Course: {course.CourseName}");
            }
            Console.WriteLine();
        }
    }
}
