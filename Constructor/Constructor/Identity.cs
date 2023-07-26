using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Identity
    {
        string name;
        string surname;
        string nationality;
        int age;
        char gender;

        public string NAME
        {
            get {  return name; }
            set { name = value.ToLower(); }
        }

        public string SURNAME
        {
            get { return surname; }
            set { surname = value.ToUpper(); }
        }

        public string NATIONALITY
        {
            get { return nationality; }
            set { nationality = value; }
        }

        public int AGE
        {
            get { return age; }
            set { age = Math.Abs(value); }
        }

        public char GENDER
        {
            get { return gender; }
            set { gender = value; }
        }

        public Identity()
        {
            name = "";
            surname = "";
            age = 25;
            gender = 'F';
            nationality = "Ankara";
        }
    }
}
