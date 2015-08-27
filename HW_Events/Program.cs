using System;

namespace HW_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            StudentFantast stFantast = new StudentFantast();
            StudentComputerScientist stCompScientist = new StudentComputerScientist();

            library.registerStudent(stFantast);
            library.registerStudent(stCompScientist);

            library.AddBook(new Book("The Lord of the rings", "Peter Jackson", "fantasy"));
            library.AddBook(new Book("Modern operating systems", "Andrew Tanenbaum", "computer science"));
            library.AddBook(new Book("Triumphal arch", "Erich Maria Remarque", "war novel"));

            Console.ReadKey();
        }
    }
}
