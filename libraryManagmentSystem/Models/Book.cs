using System;

namespace AdvancedLibraryManagementSystem.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public bool IsBorrowed => BorrowedBy != null;
        public string BorrowedBy { get; set; } = null;
        public DateTime? DueDate { get; set; } = null;

        public override string ToString()
        {
            string status = IsBorrowed ? $"Borrowed by {BorrowedBy}, Due {DueDate?.ToShortDateString()}" : "Available";
            return $"Title: {Title}, Author: {Author}, Category: {Category}, Status: {status}";
        }
    }
}
