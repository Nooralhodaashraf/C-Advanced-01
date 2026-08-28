using System;
using System.Collections.Generic;
using System.Text;

namespace C__Advanced_01
{
    internal class Zoo<T> where T : Animal,IPrintable, new()
    {
        public void Hear(T animal)
        {
            animal.Sound();//can see it 
        }
    }
}
