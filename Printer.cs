using System;
using System.Collections.Generic;
using System.Text;

namespace C__Advanced_01
{
    internal class Printer<T> where T : IPrintable
    {
        public void PrintItem(T item)
        {
            item.Print();
        }
    }
}
