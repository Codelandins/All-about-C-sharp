using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Countries : CountryDetails
    {
        public string Name;
        public string Continent;
        public string CapitalCity;
        private int economy;
        private string religious;

        //Encapsulation
        public int ECONOMY                       // This is the style that Coder wants customer to understand and access
        {                                        // That's why we use with private concerned attribute.
            get { return economy ; }             //It returns or gives the value to the set section
            set { economy = value * 1 ; }        // This is the operation section that we are applying on the section
                                                 // in the get. To sum up it is like "constrain"
        }

        public string RELIGIOUS
        {
            get { return religious ; }
            set{ religious = value.ToUpper() + "?" ;}   
        }
    }
}
