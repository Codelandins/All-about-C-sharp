using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_without_returns_in_the_classes
{
    internal class Individuals
    {
        public void personlist(string ad) //We decleared a parameter. It comes from keyboard by user or
                                          //sent by coder in the code section
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($" Person - {ad}");
            }
        }

    }
}
