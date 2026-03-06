using NUnit.Framework;
using LibraryManagementSystem;

namespace LibraryTests
{
    public class Tests
    {
        Main library;

        [SetUp]
        public void Setup()
        {
            library = new Main();
        }

        [Test]
        public void AddBook_Test()
        {
            var book = new Book("C#", "MS", "111");
            library.AddBook(book);

            Assert.AreEqual(1, library.Books.Count);
        }

        [Test]
        public void RegisterBorrower_Test()
        {
            var borrower = new Borrower("Yash", "001");
            library.RegisterBorrower(borrower);

            Assert.AreEqual(1, library.Borrowers.Count);
        }

        [Test]
        public void BorrowBook_Test()
        {
            var book = new Book("C#", "MS", "111");
            var borrower = new Borrower("Yash", "001");

            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("111", "001");

            Assert.IsTrue(book.IsBorrowed);
            Assert.AreEqual(1, borrower.BorrowedBooks.Count);
        }

        [Test]
        public void ReturnBook_Test()
        {
            var book = new Book("C#", "MS", "111");
            var borrower = new Borrower("Yash", "001");

            library.AddBook(book);
            library.RegisterBorrower(borrower);
            library.BorrowBook("111", "001");

            library.ReturnBook("111", "001");

            Assert.IsFalse(book.IsBorrowed);
            Assert.AreEqual(0, borrower.BorrowedBooks.Count);
        }

        [Test]
        public void ViewBooks_Test()
        {
            library.AddBook(new Book("Java", "Oracle", "222"));
            Assert.AreEqual(1, library.ViewBooks().Count);
        }

        [Test]
        public void ViewBorrowers_Test()
        {
            library.RegisterBorrower(new Borrower("Yash", "001"));
            Assert.AreEqual(1, library.ViewBorrowers().Count);
        }
    }
}