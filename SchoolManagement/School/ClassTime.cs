namespace SchoolManagement.School
{
    public class ClassTime : Entity
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Number { get; set; }

        public ClassTime(string name, int number   , string startTime, string endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
            Name = name;
            Number = number;
        }

        public override void AddToDatabase()
        {
            DatabaseManager.AddClassTime(Name,Number,StartTime,EndTime);
        }

        public override string ToString()
        {
            return Number + ": " + StartTime + "-" + EndTime;
        }
    }
}
