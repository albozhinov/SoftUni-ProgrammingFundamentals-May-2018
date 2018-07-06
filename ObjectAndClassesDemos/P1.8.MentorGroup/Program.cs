using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace P1._8.MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            var inputDate = Console.ReadLine();

            string studentName;
            DateTime date;
            

            while (inputDate != "end of dates")
            {
                //List<DateTime> dates = new List<DateTime>();
                var studentAndDate = inputDate.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                studentName = studentAndDate[0];
                if (!students.ContainsKey(studentName))
                {
                    Student newStudent = new Student();                    
                    newStudent.Comments = new List<string>();
                    newStudent.Date = new List<DateTime>();
                    students.Add(studentName, newStudent);
                }

                for (int i = 1; i < studentAndDate.Length; i++)
                {
                    date = DateTime.ParseExact(studentAndDate[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    students[studentName].Date.Add(date);
                }    
               

                inputDate = Console.ReadLine();
            }

            var comment = Console.ReadLine();

            while (comment != "end of comments")
            {
                var commentAndStudent = comment.Split('-').ToArray();
                studentName = commentAndStudent[0];
                var currComent = commentAndStudent[1];

                if (!students.ContainsKey(studentName))
                {
                    comment = Console.ReadLine();
                    continue;
                }
                students[studentName].Comments.Add(currComent);

                comment = Console.ReadLine();
            }

            foreach (var pair in students.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{pair.Key}");
                Console.WriteLine("Comments:");
                foreach (var item in students[pair.Key].Comments)
                {
                    Console.WriteLine($"- {item}");
                }
                Console.WriteLine($"Dates attended:");
                foreach (var item in students[pair.Key].Date.OrderBy(x => x.Date))
                {
                    Console.WriteLine($"-- {item.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
                }
            }


        }
    }

    class Student
    {
        public List<string> Comments { get; set; }

        public List<DateTime> Date { get; set; }
    }
}
