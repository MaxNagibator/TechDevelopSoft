namespace SchoolManagement.School
{
    public class ClassTimeTableDayElem
    {
        public int ClassTimeNumber { get; set; }
        public string Text { get; set; }
        public ClassTimeTable ClassTimeTable { get; set; }

        public ClassTimeTableDayElem(string text, int classTimeNumber, ClassTimeTable classTimeTable)
        {
            Text = text;
            ClassTimeNumber = classTimeNumber;
            ClassTimeTable = classTimeTable;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
