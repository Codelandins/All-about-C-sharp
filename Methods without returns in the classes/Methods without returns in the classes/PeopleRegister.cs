using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_without_returns_in_the_classes
{
    internal class PeopleRegister
    {
        public void register(string adsoyad) 
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(adsoyad);
            }
        }
    }
}
