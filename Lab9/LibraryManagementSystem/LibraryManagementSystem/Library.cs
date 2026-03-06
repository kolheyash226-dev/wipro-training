using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Main
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Borrower> Borrowers { get; set; } = new List<Borrower>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RegisterBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }

        public void BorrowBook(string isbn, string cardNumber)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn);
            var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == cardNumber);

            borrower.BorrowBook(book);
        }

        public void ReturnBook(string isbn, string cardNumber)
        {
            var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == cardNumber);
            var book = borrower.BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);

            borrower.ReturnBook(book);
        }

        public List<Book> ViewBooks()
        {
            return Books;
        }

        public List<Borrower> ViewBorrowers()
        {
            return Borrowers;
        }
    }
}
