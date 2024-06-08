using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
    internal class Doctor : ICloneable // Доктор пишет диагно по каждой болезни больного 
    {
        internal string DoctorSurname { get; set; }
        internal string DoctorName { get; set; }
        internal DateTime DoctorDateBirth { get; set; }
        internal string DoctorProfession { get; set; }
        internal string DoctorSpecialization { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
