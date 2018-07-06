using System;
using System.Linq;
using System.Collections.Generic;

namespace P04
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> myStudents = new List<Student>();
            Dictionary<string, int> allLenaguage = new Dictionary<string, int>();


            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "exam finished")
                {
                    break;
                }
                var studentInfo = inputLine
                               .Split(new char[] { '-' },
                               StringSplitOptions.RemoveEmptyEntries)
                               .ToList();
                if (studentInfo[1] == "banned")
                {
                    var currName = studentInfo[0];
                    var currList = myStudents.Where(s => s.Name != currName).ToList();
                    myStudents = currList;
                    continue;
                }


                var name = studentInfo[0];
                var language = studentInfo[1];
                var points = int.Parse(studentInfo[2]);

                
                if (!myStudents.Any(s => s.Name == name))
                {
                    Student currstudent = new Student();
                    currstudent.Name = name;
                    currstudent.Language = language;
                    currstudent.Points = points;
                    myStudents.Add(currstudent);
                }
                else
                {
                    var helper = myStudents.First(s => s.Name == name);
                    if (helper.Points < points)
                    {
                        helper.Points = points;
                    }
                }

                if (!allLenaguage.ContainsKey(language))
                {
                    allLenaguage.Add(language, 1);
                }
                else
                {
                    allLenaguage[language] += 1;
                }
            }
            Console.WriteLine("Results:");
            foreach (var item in myStudents.OrderByDescending(x => x.Points).ThenBy(y => y.Name))
            {
                Console.WriteLine($"{item.Name} | {item.Points}");
            }

            Console.WriteLine("Submissions:");
            foreach (var item in allLenaguage.OrderByDescending(l => l.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
    class Student
    {
        public string Name { get; set; }

        public string Language { get; set; }

        public int Points { get; set; }
    }
}
