using System;

namespace SchoolManagement.School
{
    public class ClassTimeTable : Entity
    {
        public ClassTime ClassTime { get; set; }
        public EducationalDiscipline EducationalDiscipline { get; set; }
        public DateTime Date { get; set; }
        public Teacher Teacher { get; set; }
        public ClassRoom ClassRoom { get; set; }
        public Group Group { get; set; }

        public ClassTimeTable(string name, DateTime date, ClassTime classTime, EducationalDiscipline educationalDiscipline, Teacher teacher, ClassRoom classRoom, Group group)
        {
            Name = name;
            Date = date;
            ClassTime = classTime;
            EducationalDiscipline = educationalDiscipline;
            Teacher = teacher;
            ClassRoom = classRoom;
            Group = group;
        }

        public ClassTimeTable(Group group, DateTime date, ClassTime classTime)
        {
            Group = group;
            Date = date;
            ClassTime = classTime;
        }

        public override void AddToDatabase()
        {
           DatabaseManager.AddClassTimeTable(Name, ClassTime.Id,EducationalDiscipline.Id,Date,Teacher.Id,ClassRoom.Id,Group.Id);
        }
    }
}
