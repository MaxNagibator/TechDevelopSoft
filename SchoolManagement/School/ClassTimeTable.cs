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


        public override void AddToDatabase()
        {
            throw new System.NotImplementedException();
        }
    }
}
