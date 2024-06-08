using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
    internal class Diagnosis :  IMyCloneable<Diagnosis>, ICloneable // Диагноз пациента, класс пациент (Patient) наследует класс Диагноз (Diagnosis)
    {
        internal Dictionary<Doctor, Disease> diagnosisData { get; set; }

        public Diagnosis(Disease disease, Doctor doctor) 
        {
            diagnosisData = new Dictionary<Doctor, Disease>();
            diagnosisData.Add(doctor, disease);
        }

        public Diagnosis MuCloneClass()
        {

            Diagnosis _diagnosis =  new Diagnosis(diagnosisData.Values.GetEnumerator().Current, diagnosisData.Keys.GetEnumerator().Current);
            foreach (var data in diagnosisData) 
            {
                _diagnosis.AddDiagnosis(data.Key, data.Value);
            }
            return _diagnosis;

        }

      internal  void AddDiagnosis(Doctor doctor, Disease disease)
        {
            if (diagnosisData.Count == 0||diagnosisData==null)
            {
                diagnosisData = new Dictionary<Doctor, Disease>();
                diagnosisData.Add(doctor, disease);
            }
            diagnosisData.Add(doctor, disease);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
