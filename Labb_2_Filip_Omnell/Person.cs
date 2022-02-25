using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_OOP
{
    public abstract class Person : IComparable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public static int ehhInt = 0;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            Gender = "Unknown";
        }

        public abstract string GetName();
        public abstract string GetNameForSearch();

        public int CompareTo(Person other)
        {
            if(ehhInt == 0)
            {
                return LastName.CompareTo(other.LastName);
            }

            if(ehhInt == 1)
            {
                return FirstName.CompareTo(other.FirstName);
            }

            return LastName.CompareTo(other.LastName);
        }
    }
}
