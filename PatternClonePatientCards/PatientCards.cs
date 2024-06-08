using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PatternClonePatientCards
{
   internal class PatientCards: Patient, IMyCloneable<PatientCards>, ICloneable // У карточки пациента есть Инфорация о пациенте (Patient) а пациент в свою очередь наследует диагноз (Diagnosis)
    {
        public PatientCards() : base(string.Empty, string.Empty, DateTime.Now)
        {
        }

        public  PatientCards MuCloneClass()
        {

            PatientCards _patientCards = new PatientCards();

            _patientCards.PatientName = base.PatientName;
            _patientCards.PatientSurname = base.PatientSurname;
            _patientCards.PatientDateBirth = base.PatientDateBirth;
            foreach (var p in base.diagnosisData)
            {
                _patientCards.AddDiagnosis(p.Key, p.Value);
            }

            return _patientCards;
        }


        public new object Clone()
        {
            return MemberwiseClone();
        }

    }
}
