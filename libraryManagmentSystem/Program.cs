using System;
using AdvancedLibraryManagementSystem.Models;
using AdvancedLibraryManagementSystem.Services;

namespace AdvancedLibraryManagementSystem
{
    class Program
    {
        static string booksFile = "Data/books.json";
        static string usersFile = "Data/users.json";

        static Library library;
        static User currentUser;

        static void Main(string[] args)
        {
            // Ensure data folder exists
            System.IO.Directory.CreateDirectory("Data");

            // Load data or initialize
            library = Library.Load(booksFile);
            UserManager.Load(usersFile);

            Console.WriteLine("Welcome to Advanced Library Management System!");

            while (true)
            {
                if (currentUser == null)
                {
                    Console.WriteLine("\n1. Register");
                    Console.WriteLine("2. Login");
                    Console.WriteLine("3. Exit");
                    Console.Write("Choose: ");
                    var choice = Console.ReadLine();

                    if (choice == "1") Register();
                    else if (choice == "2") Login();
                    else if (choice == "3") break;
                    else Console.WriteLine("Invalid choice");
                }
                else
                {
                    if (currentUser.IsAdmin)
                        AdminMenu();
                    else
                        UserMenu();
                }
            }

            // Save data on exit
            library.Save(booksFile);
            UserManager.Save(usersFile);
            Console.WriteLine("Goodbye!");
        }

        static void Register()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            if (UserManager.UserExists(username))
            {
                Console.WriteLine("Username already exists!");
                return;
            }
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            UserManager.AddUser(new User { Username = username, Password = password, IsAdmin = false });
            UserManager.Save(usersFile);
            Console.WriteLine("User registered successfully!");
        }

        static void Login()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            var user = UserManager.Authenticate(username, password);
            if (user == null)
                Console.WriteLine("Invalid credentials!");
            else
            {
                currentUser = user;
                Console.WriteLine($"Welcome {currentUser.Username}!");
            }
        }

        static void AdminMenu()
        {
            Console.WriteLine("\nAdmin Menu:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. View All Users");
            Console.WriteLine("4. Logout");
            Console.Write("Choose: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    library.ViewBooks();
                    break;
                case "3":
                    UserManager.ViewUsers();
                    break;
                case "4":
                    currentUser = null;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static void UserMenu()
        {
            Console.WriteLine($"\nUser Menu ({currentUser.Username}):");
            Console.WriteLine("1. View Available Books");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. Return Book");
            Console.WriteLine("4. View My Borrowed Books");
            Console.WriteLine("5. Logout");
            Console.Write("Choose: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    library.ViewAvailableBooks();
                    break;
                case "2":
                    BorrowBook();
                    break;
                case "3":
                    ReturnBook();
                    break;
                case "4":
                    ViewBorrowedBooks();
                    break;
                case "5":
                    currentUser = null;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static void AddBook()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Category: ");
            string category = Console.ReadLine();

            library.AddBook(new Book
            {
                Title = title,
                Author = author,
                Category = category
            });
            library.Save(booksFile);
            Console.WriteLine("Book added!");
        }

        static void BorrowBook()
        {
            Console.Write("Enter book title to borrow: ");
            string title = Console.ReadLine();

            bool success = library.BorrowBook(title, currentUser.Username);

            if (success)
            {
                library.Save(booksFile);
                Console.WriteLine("Book borrowed successfully. Due in 14 days.");
            }
            else
            {
                Console.WriteLine("Book not available or does not exist.");
            }
        }

        static void ReturnBook()
        {
            Console.Write("Enter book title to return: ");
            string title = Console.ReadLine();

            bool success = library.ReturnBook(title, currentUser.Username, out int overdueDays);

            if (success)
            {
                library.Save(booksFile);
                if (overdueDays > 0)
                {
                    Console.WriteLine($"Book returned successfully. You have {overdueDays} overdue days. Fine: ${overdueDays * 1}");
                }
                else
                {
                    Console.WriteLine("Book returned successfully. No fines.");
                }
            }
            else
            {
                Console.WriteLine("Return failed. You may not have borrowed this book.");
            }
        }

        static void ViewBorrowedBooks()
        {
            var borrowed = library.GetBorrowedBooksByUser(currentUser.Username);
            if (borrowed.Count == 0)
            {
                Console.WriteLine("You have no borrowed books.");
                return;
            }

            Console.WriteLine("Your borrowed books:");
            foreach (var book in borrowed)
            {
                Console.WriteLine($"{book.Title} - Due Date: {book.DueDate?.ToShortDateString()}");
            }
        }
    }
}
