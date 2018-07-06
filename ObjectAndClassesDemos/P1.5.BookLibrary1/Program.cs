using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace P1._5.BookLibrary1
{
    class Program
    {
        static void Main(string[] args)
        {
            int booksCount = int.Parse(Console.ReadLine());
            Library newLibrary = new Library("Gosho's Library");                  

            for (int i = 0; i < booksCount; i++)
            {                
                var inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string title = inputLine[0];
                string author = inputLine[1];
                string publisher = inputLine[2];
                DateTime date = DateTime.ParseExact(inputLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbnNumber = inputLine[4];
                decimal price = decimal.Parse(inputLine[5]);

                Book currBook = null;

                if (!newLibrary.Books.Any(b => b.Author == author))
                {
                    currBook = new Book(title, author, publisher, date, isbnNumber, price);
                    newLibrary.Books.Add(currBook);
                }
                else
                {
                    currBook = newLibrary.Books.First(b => b.Author == author);
                    currBook.Price += price;
                }                              
            }     

            foreach (var item in newLibrary.Books.OrderByDescending(p => p.Price).ThenBy(a => a.Author))
            {
                var autors = item.Author;
                Console.WriteLine($"{autors} -> {item.Price:f2}");
            }
        }
    }

    class Library
    {
        public Library(string name)
        {
            this.Name = name;
            this.Books = new List<Book>();
        }

        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
    class Book
    {
        public Book(string title, string author, string publisher, DateTime date, string isbnNumber, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.Date = date;
            this.ISBNNumber = isbnNumber;
            this.Price = price;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime Date { get; set; }
        
        public string ISBNNumber { get; set; }

        public decimal Price { get; set; }
    }
}
