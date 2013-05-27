using System;
using System.Collections.Generic;

namespace SchoolManagement.School
{
    public class Student : Entity
    {
        public DateTime BirthDay { get; set; }
        public Group Group { get; set; }
        public string Comment { get; set; }
        public List<StudentRate> Rate { get; set; }

        public Student(string name, DateTime birthDay, string comment, Group group)
        {
            Name = name;
            BirthDay = birthDay;
            Comment = comment;
            Group = group;
        }

        public Student()
        {
            
        }

        public override void AddToDatabase()
        {
            DatabaseManager.AddStudent(Name, BirthDay, Comment, Group.Id);
        }
    }
}
