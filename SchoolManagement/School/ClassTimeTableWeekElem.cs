using System.ComponentModel;

namespace SchoolManagement.School
{
    public class ClassTimeTableWeekElem
    {
        [DisplayName("Понедельник")]
        public ClassTimeTableDayElem Day1 { get; set; }

        [DisplayName("Вторник")]
        public ClassTimeTableDayElem Day2 { get; set; }

        [DisplayName("Среда")]
        public ClassTimeTableDayElem Day3 { get; set; }

        [DisplayName("Четверг")]
        public ClassTimeTableDayElem Day4 { get; set; }

        [DisplayName("Пятница")]
        public ClassTimeTableDayElem Day5 { get; set; }

        [DisplayName("Суббота")]
        public ClassTimeTableDayElem Day6 { get; set; }

        [DisplayName("Воскресение")]
        public ClassTimeTableDayElem Day7 { get; set; }

        [DisplayName("Время урока")]
        public ClassTime ClassTime { get; set; }
    }
}
