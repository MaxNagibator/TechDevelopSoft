using System.ComponentModel;

namespace SchoolManagement.School
{
    public class ClassTime : Entity
    {
        public int Id { get; set; }

        [DisplayName("Номер")]
        public int Number { get; set; }
        [DisplayName("Начало урока")]
        public string StartTime { get; set; }
        [DisplayName("Конец урока")]
        public string EndTime { get; set; }

        public ClassTime(int number   , string startTime, string endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
            Number = number;
        }

        public override void AddToDatabase()
        {
            DatabaseManager.AddClassTime("Рудимент типа", Number, StartTime, EndTime);
        }

        public override string ToString()
        {
            if (Number == -606217)
            {
                return "Группа: " + StartTime;
            }
            return Number + ": " + StartTime + "-" + EndTime;
        }

        public override void UpdateInDatabase(int id)
        {
            DatabaseManager.UpdateClassTime(id, "Рудимент типа", Number, StartTime, EndTime);
        }
    }
}
