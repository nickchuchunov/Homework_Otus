
using PatternClonePatientCards;

Patient patient = new Patient("Ivanov", "Ivan", new DateTime(1990, 11, 12));
PatientCards cards = new PatientCards(patient);
cards.DiseaseHistory.Add("Doctor", "History of illness, etc.");


PatientCards cards_2 = cards.Clone();

Console.WriteLine($"Patient Surname - {cards_2.patient.Surname} Patient Name - {cards_2.patient.Name}  Patient DateBirth -  {cards_2.patient.DateBirth}  DiseaseHistory Value - {cards_2.DiseaseHistory["Doctor"]} ");