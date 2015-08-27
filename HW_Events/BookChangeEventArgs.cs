using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Events
{
    public class BookChangeEventArgs : EventArgs
    {
        private Book _book;

        public BookChangeEventArgs(Book book)
        {
            _book = book;
        }

        public Book Book
        {
            get { return _book; }
        }
    }
}