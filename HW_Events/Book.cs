using System;

namespace HW_Events
{
    public class Book
    {
        private string _bookName;
        private string _authorsName;
        private string _genre;

        public Book(string bookName, string authorName, string genre)
        {
            _bookName = bookName;
            _authorsName = authorName;
            _genre = genre;
        }

        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value;}
        }

        public string AuthorsName
        {
            get { return _authorsName; }
            set { _authorsName = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
    }
}
