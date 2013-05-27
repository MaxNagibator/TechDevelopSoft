namespace SchoolManagement.School
{
    public class ClassTime : Entity
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public override void AddToDatabase()
        {
            throw new System.NotImplementedException();
        }
    }
}
