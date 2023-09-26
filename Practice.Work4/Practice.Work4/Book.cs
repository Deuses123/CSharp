using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Work4
{

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Title} by {Author}, Year: {Year}";
        }
    }
    class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public List<Book> SearchByAuthor(string author)
        {
            return books.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Book> SearchByYear(int year)
        {
            return books.Where(book => book.Year == year).ToList();
        }

        public void SortByTitle()
        {
            books.Sort((book1, book2) => book1.Title.CompareTo(book2.Title));
        }

        public void SortByAuthor()
        {
            books.Sort((book1, book2) => book1.Author.CompareTo(book2.Author));
        }

        public void SortByYear()
        {
            books.Sort((book1, book2) => book1.Year.CompareTo(book2.Year));
        }

        public void DisplayLibrary()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
