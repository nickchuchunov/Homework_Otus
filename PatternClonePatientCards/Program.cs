
using PatternClonePatientCards;


// PatientCards (карточка пациента) в котором проверяется работа паттерна Прототип (своей реализации) и интерфейса ICloneable
// Он наследует класс Patient который в свою очередь наследует Diagnosis 

Doctor doctor = new Doctor();
doctor.DoctorName = "Bob";
doctor.DoctorSurname = "Martinius";
doctor.DoctorDateBirth = DateTime.Now;
doctor.DoctorProfession = "InfectiousDiseasel";
doctor.DoctorSpecialization = "Infectious";

Disease disease = new Disease();
disease.Name = "Flu";
disease.Description = "Respiratory disease";


PatientCards patientCards = new PatientCards();
patientCards.PatientName = "Bob";
patientCards.PatientSurname = "Martinius";
patientCards.PatientDateBirth = DateTime.Now;
patientCards.AddDiagnosis(doctor, disease);


PatientCards patientCardsMuCloneClass = patientCards.MuCloneClass();

PatientCards patientCardsClone = (PatientCards) patientCards.Clone();

// Выводим в консоль клон из метода MuCloneClass

Console.WriteLine($"Имя пациента {patientCardsMuCloneClass.PatientName} Фамилия пациента {patientCardsMuCloneClass.PatientSurname} Дата рождения пациента {patientCardsMuCloneClass.PatientDateBirth}  ");
foreach (var data in patientCardsMuCloneClass.diagnosisData) 
{ 
    Console.WriteLine($"Доктор говорит вы больны {data.Key.DoctorName} Такой то вот болезнm {data.Value.Name} ");
}

// Выводим в консоль клон из интерфейса ICloneable

Console.WriteLine($"Имя пациента {patientCardsClone.PatientName} Фамилия пациента {patientCardsClone.PatientSurname} Дата рождения пациента {patientCardsClone.PatientDateBirth}  ");
foreach (var data in patientCardsClone.diagnosisData)
{
    Console.WriteLine($"Доктор говорит вы больны {data.Key.DoctorName} Такой то вот болезнm {data.Value.Name} ");
}

// Вывод метод интерфейса ICloneable  в Net 8 способен  клонировать наследуемые свойства класса