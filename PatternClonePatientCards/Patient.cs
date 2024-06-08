using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PatternClonePatientCards
{
    internal class Patient : Diagnosis, IMyCloneable<Patient>, ICloneable // У пациента есть диагноз 
    {
        internal string PatientSurname { get; set; }
        internal string PatientName { get; set; }
        internal DateTime PatientDateBirth { get; set; }

        internal Patient (string surname, string name, DateTime dateBirth  ) :base( new Disease () , new Doctor ())
        {
            PatientSurname = surname;
            PatientName = name;
            PatientDateBirth = dateBirth; 
        }

      
      public new Patient MuCloneClass()
        {
            Patient _Patient = new Patient (PatientSurname, PatientName, PatientDateBirth);
            foreach ( var p in base.diagnosisData)
            {
                _Patient.AddDiagnosis(p.Key, p.Value);
            }
            return _Patient;
        }

        public new object Clone()
        {
            return MemberwiseClone();
        }


    }
}
