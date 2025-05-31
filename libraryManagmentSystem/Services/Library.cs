using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using AdvancedLibraryManagementSystem.Models;

namespace AdvancedLibraryManagementSystem.Services
{
    public class Library
    {
        private List<Book> books = new();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ViewBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            foreach (var b in books)
            {
                Console.WriteLine(b);
            }
        }

        public void ViewAvailableBooks()
        {
            var available = books.Where(b => !b.IsBorrowed).ToList();

            if (available.Count == 0)
            {
                Console.WriteLine("No available books right now.");
                return;
            }

            foreach (var b in available)
            {
                Console.WriteLine(b);
            }
        }

        public bool BorrowBook(string title, string username)
        {
            var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase) && !b.IsBorrowed);

            if (book != null)
            {
                book.BorrowedBy = username;
                book.DueDate = DateTime.Now.AddDays(14);
                return true;
            }
            return false;
        }

        public bool ReturnBook(string title, string username, out int overdueDays)
        {
            overdueDays = 0;
            var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase) && b.BorrowedBy == username);
            if (book != null)
            {
                if (book.DueDate.HasValue && DateTime.Now > book.DueDate.Value)
                {
                    overdueDays = (DateTime.Now - book.DueDate.Value).Days;
                }

                book.BorrowedBy = null;
                book.DueDate = null;
                return true;
            }
            return false;
        }

        public List<Book> GetBorrowedBooksByUser(string username)
        {
            return books.Where(b => b.BorrowedBy == username).ToList();
        }

        public void Save(string filename)
        {
            var json = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filename, json);
        }

        public static Library Load(string filename)
        {
            if (!File.Exists(filename))
                return new Library();

            var json = File.ReadAllText(filename);
            var loadedBooks = JsonSerializer.Deserialize<List<Book>>(json);
            return new Library { books = loadedBooks ?? new List<Book>() };
        }
    }
}
