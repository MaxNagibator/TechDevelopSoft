using System.ComponentModel;

namespace SchoolManagement.School
{
    public class Group : Entity
    {
        public int Id { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Комментарий")]
        public string Comment { get; set; }

        public Group(string name, string comment)
        {
            Name = name;
            Comment = comment;
        }

        public Group(int id)
        {
            Id = id;
        }

        public override void AddToDatabase()
        {
            DatabaseManager.AddGroup(Name, Comment);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
