using System;

namespace Interfaces
{
    public class PatientImportData
    {
        public enum GenderType
        {
            Male,
            Female,
        }

        public string PersonalCode { get; set; }
        public string MedicalCardNumber { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Gender { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
