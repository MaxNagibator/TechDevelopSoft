using SchoolManagement;
using SchoolManagement.School;

namespace MyFirstTest
{
    public class MockClassRoom : Entity
    {
        public string Number { get; set; }

        public MockClassRoom(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public void AddToDatabase(MockLocalSettings mockLocalSettings)
        {
            using (var sqlProvider = mockLocalSettings.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Name", Name);
                sqlProvider.SetParameter("@Number", Number);
                sqlProvider.ExecuteQuery(@"INSERT INTO [ClassRoom] (Name, Number) VALUES(@Name, @Number)");
            }
        }

        public override string ToString()
        {
            return Number;
        }

        public override void AddToDatabase()
        {
            throw new System.NotImplementedException();
        }
    }
}
