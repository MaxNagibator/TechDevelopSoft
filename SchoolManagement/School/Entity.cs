namespace SchoolManagement.School
{
    public abstract  class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void AddToDatabase();
    }
}
