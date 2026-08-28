using System;
using System.Collections.Generic;
using System.Text;

namespace C__Advanced_01
{
    internal class Student : IPrintable
    {
        public Student() { }
        public void Print()
        {
            Console.WriteLine("Student");
        }
    }
}
