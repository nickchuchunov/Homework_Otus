using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
    internal class Patient
    {
        internal string Surname { get; set; }
        internal string Name { get; set; }
        internal DateTime DateBirth { get; set; }

        internal Patient (string surname, string name, DateTime dateBirth) 
        {
            Surname = surname;
            Name = name;
            DateBirth = dateBirth;
        }
    }
}
