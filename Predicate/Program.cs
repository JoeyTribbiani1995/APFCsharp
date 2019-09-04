using System;
using System.Drawing;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = { new Point(100, 200),
                               new Point(275, 395), new Point(295, 450)};

            Predicate<Point> predicate = FindPoints;

            Point first = Array.Find(points, predicate);

            // Display the first structure found.
            Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);

            //praticing

            Predicate<Student> predicateStudent = FindName;

            Student[] students =
            {
                new Student("Joey"),
                new Student("Joey"),
                new Student("Ross")
            };

            var stu = Array.FindIndex(students, predicateStudent);

            Console.WriteLine(stu);

            Console.ReadKey();
        }

        private static bool FindPoints(Point obj)
        {
            return obj.X * obj.Y > 100000;
        }

        private static bool FindName(Student student)
        {
            return student.Name.Equals("Joey");
        }
    }

    public class Student
    {
        

        public Student(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
