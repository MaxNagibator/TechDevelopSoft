using System.ComponentModel;

namespace SchoolManagement.School
{
    public class EducationalDiscipline : Entity
    {
        public int Id { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Описание")]
        public string Description { get; set; }

        public EducationalDiscipline(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override void AddToDatabase()
        {
            DatabaseManager.AddEducationalDiscipline(Name,Description);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
