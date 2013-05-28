namespace SchoolManagement.School
{
    public class Group : Entity
    {

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
