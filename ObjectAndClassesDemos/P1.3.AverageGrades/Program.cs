using System;
using System.Linq;
using System.Collections.Generic;

namespace P1._3.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<Student> ourClass = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student person = new Student();
                var inputLine = Console.ReadLine().Split(' ').ToList();

                person.Name = inputLine[0];
                inputLine.RemoveAt(0);
                person.Grades = inputLine.Select(double.Parse).ToList();
                ourClass.Add(person);
            }
            foreach (var person in ourClass.Where(x => x.Avarage >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.Avarage))
            {
                Console.WriteLine($"{person.Name} -> {person.Avarage:F2}");
            }
        }
    }
    class Student
    {     
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double Avarage { get { return Grades.Average(); } }
    }
}
