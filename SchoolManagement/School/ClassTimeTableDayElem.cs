namespace SchoolManagement.School
{
    public class ClassTimeTableDayElem
    {

        public string Text { get; set; }
        public ClassTime ClassTime { get; set; }
        public ClassTimeTable ClassTimeTable { get; set; }

        public ClassTimeTableDayElem(string text, ClassTime classTime, ClassTimeTable classTimeTable)
        {
            Text = text;
            ClassTime = classTime;
            ClassTimeTable = classTimeTable;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
