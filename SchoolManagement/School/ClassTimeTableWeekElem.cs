namespace SchoolManagement.School
{
    public class ClassTimeTableWeekElem
    {
        [System.ComponentModel.DisplayName("Понедельник")]
        public ClassTimeTableDayElem Day1 { get; set; }

        [System.ComponentModel.DisplayName("Вторник")]
        public ClassTimeTableDayElem Day2 { get; set; }

        [System.ComponentModel.DisplayName("Среда")]
        public ClassTimeTableDayElem Day3 { get; set; }

        [System.ComponentModel.DisplayName("Четверг")]
        public ClassTimeTableDayElem Day4 { get; set; }

        [System.ComponentModel.DisplayName("Пятница")]
        public ClassTimeTableDayElem Day5 { get; set; }

        [System.ComponentModel.DisplayName("Суббота")]
        public ClassTimeTableDayElem Day6 { get; set; }

        [System.ComponentModel.DisplayName("Воскресение")]
        public ClassTimeTableDayElem Day7 { get; set; }

        [System.ComponentModel.DisplayName("Время урока")]
        public ClassTime ClassTime { get; set; }
    }
}
