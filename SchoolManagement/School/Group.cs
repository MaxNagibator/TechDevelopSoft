namespace SchoolManagement.School
{
    public class Group : Entity
    {
        public Group()
        {
        }

        public Group(int id)
        {
            Id = id;
        }

        public Group(string name, string comment)
        {
            Name = name;
            Comment = comment;
        }

        public string Comment { get; set; }

        public override void AddToDatabase()
        {
            DatabaseManager.AddGroup(Name, Comment);
        }
    }
}
