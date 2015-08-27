using System;

namespace HW_Events
{
    public abstract class Student
    {
        public abstract void OnBookChangeEvent(object sender, BookChangeEventArgs args);
    }
}
