namespace SchoolManagement.School
{
    public class EducationalDiscipline : Entity
    {
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
    }
}
