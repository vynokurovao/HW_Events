using System;

namespace HW_Events
{
    public class StudentFantast : Student
    {
        public override void OnBookChangeEvent(object sender, BookChangeEventArgs args)
        {
            if (args.Book.Genre.Equals("fantasy"))
            {
                Console.WriteLine("The fantasy-lover ordered this book with a delivery");
            }
            else
            {
                Console.WriteLine("The fantasy-lover will not read this book");
            }
        }
    }
}
