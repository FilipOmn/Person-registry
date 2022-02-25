using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_OOP
{
    public class Female : Person
    {
        public Female(string firstName, string lastName)
            : base(firstName, lastName)
        {
            Gender = "Mrs.";
        }

        //Skickar tillbaka personens fulla namn och kön.
        public override string GetName()
        {
            return $"{Gender}       {FirstName} {LastName}";
        }

        //Skickar tillbaka endast förnamn och efternamn för sökfuntionen
        public override string GetNameForSearch()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
