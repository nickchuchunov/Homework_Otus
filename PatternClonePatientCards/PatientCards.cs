using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
    internal class PatientCards
    {
        internal Patient patient;
        internal  Dictionary<string, string> DiseaseHistory; // история болезни Key - врачь, Value - история

        internal PatientCards(Patient _patient)
        {
            patient = _patient;
            DiseaseHistory = new Dictionary<string, string>();
        }


        internal PatientCards Clone()
        {
            Patient patientClone = new Patient(patient.Surname, patient.Name, patient.DateBirth);
            PatientCards patientCardsClone = new PatientCards(patientClone);
            foreach (var dictionaryKeyValue in DiseaseHistory) 
            {
                patientCardsClone.DiseaseHistory.Add(dictionaryKeyValue.Key, dictionaryKeyValue.Value);
            }

            return patientCardsClone;
        }

    }
}
