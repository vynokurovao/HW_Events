using System;
using System.Collections.Generic;

namespace HW_Events
{
    public class Library
    {
        private List<Book> _library = new List<Book>();

        private delegate void BookEventHandler(object sender, BookChangeEventArgs args);

        private event BookEventHandler BookAdded;
        private event BookEventHandler BookTaken;

        public void registerStudent(Student student)
        {
            BookAdded += new BookEventHandler(student.OnBookChangeEvent);
            BookTaken += new BookEventHandler(student.OnBookChangeEvent);
        }

        public void AddBook(Book book)
        {
            _library.Add(book);
            if (BookAdded != null)
            {
                BookAdded(this, new BookChangeEventArgs(book));
            }
        }

        public Book TakeBook(Book book)
        {
            if (!_library.Contains(book))
            {
                throw new ArgumentException("There is no book with such name in the library");
            }

            if (BookAdded != null)
            {
                BookTaken(this, new BookChangeEventArgs(book));
                _library.Remove(book);
            }

            return book;
        }
    }
}
