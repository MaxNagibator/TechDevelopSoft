namespace SchoolManagement.School
{
    public class ClassTimeTableDayElem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public ClassTimeTable ClassTimeTable { get; set; }

        public ClassTimeTableDayElem(string text, ClassTimeTable classTimeTable)
        {
            Text = text;
            ClassTimeTable = classTimeTable;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
