using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace P1._5.BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<Books> library = new List<Books>();
            for (int i = 0; i < n; i++)
            {
                Books newBook = new Books();
                var inputLine = Console.ReadLine().Split(' ').ToList();
                newBook.Name = inputLine[0];
                newBook.Date = DateTime.ParseExact(inputLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                library.Add(newBook);
            }
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in library.Where(x=>x.Date > date).OrderBy(x=>x.Date).ThenBy(x=>x.Name))
            {
                Console.WriteLine($"{book.Name} -> {book.Date.ToString("dd.MM.yyyy")}");
            }
        }
    }

    class Books
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }
    }

}
