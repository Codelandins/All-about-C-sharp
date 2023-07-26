using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_without_returns_in_the_classes
{
    internal class operations
    {
        public int sum(string a, string b)    
        {
            int result = Convert.ToInt16(a) + Convert.ToInt16(b);
            Console.Write("result" +  result);
            return result;
        }

        public int multipliction( string x, string y ) 
        { 
            int result2 = Convert.ToInt16(x) * Convert.ToInt16(y);
            Console.Write("result" + result2);
            return result2;
        }
    }
}
