using System.Net.Mime;

namespace SchoolManagement.School
{
    public class ClassTimeTableWeekElem
    {
        public int ClassTimeNumber { get; set; }

        [System.ComponentModel.DisplayName("Понедельник")]
        public string Day1 { get; set; }

        [System.ComponentModel.DisplayName("Вторник")]
        public string Day2 { get; set; }

        [System.ComponentModel.DisplayName("Среда")]
        public string Day3 { get; set; }

        [System.ComponentModel.DisplayName("Четверг")]
        public string Day4 { get; set; }

        [System.ComponentModel.DisplayName("Пятница")]
        public string Day5 { get; set; }

        [System.ComponentModel.DisplayName("Суббота")]
        public string Day6 { get; set; }

        [System.ComponentModel.DisplayName("Воскресение")]
        public string Day7 { get; set; }

        public ClassTimeTable ClassTimeTable1 { get; set; }
        public ClassTimeTable ClassTimeTable2 { get; set; }
        public ClassTimeTable ClassTimeTable3 { get; set; }
        public ClassTimeTable ClassTimeTable4 { get; set; }
        public ClassTimeTable ClassTimeTable5 { get; set; }
        public ClassTimeTable ClassTimeTable6 { get; set; }
        public ClassTimeTable ClassTimeTable7 { get; set; }
    }
}
