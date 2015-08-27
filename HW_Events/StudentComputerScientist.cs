using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Events
{
    public class StudentComputerScientist : Student
    {
        public override void OnBookChangeEvent(object sender, BookChangeEventArgs args)
        {
            if (args.Book.Genre == "computer science")
            {
                Console.WriteLine("The computer scientist is going to the library to take this book");
            }
        }
    }
}
