using System;
using System.Collections.Generic;

namespace SchoolManagement.School
{
    public class Teacher : Entity
    {
        public DateTime BirthDay { get; set; }
        public DateTime StartWorkDate { get; set; }
        public List<EducationalDiscipline> EducationalDisciplines { get; set; }

        public Teacher(string name, DateTime birthDay, DateTime startWorkDate)
        {
            Name = name;
            BirthDay = birthDay;
            StartWorkDate = startWorkDate;
        }

        public override void AddToDatabase()
        {
            DatabaseManager.AddTeacher(Name,BirthDay,StartWorkDate);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
