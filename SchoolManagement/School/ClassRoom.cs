namespace SchoolManagement.School
{
    public class ClassRoom : Entity
    {
        public string Number { get; set; }

        public ClassRoom(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public override void AddToDatabase()
        {
            DatabaseManager.AddClassRoom(Name,Number);
        }

        public override string ToString()
        {
            return Number;
        }
    }
}
