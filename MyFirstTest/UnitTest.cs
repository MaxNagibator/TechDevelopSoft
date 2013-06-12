using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolManagement.School;

namespace MyFirstTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestClassTimeToString()
        {
            var c = new ClassTime("1", 1, "2", "3");
            Assert.AreEqual(c.ToString(), "1: 2-3", "Не верны данные");
        }

        [TestMethod]
        public void TestGroupToString()
        {
            var c = new Group("1", "2");
            Assert.AreEqual(c.ToString(), "1", "Не верны данные");

            var g = new Group(1);
            Assert.AreEqual(g.ToString(), null, "Не верны данные");
        }

        [TestMethod]
        public void TestClassRoomToString()
        {
            var c = new ClassRoom("1", "3");
            Assert.AreEqual(c.ToString(), "3", "Не верны данные");
        }

        [TestMethod]
        public void TestTeacherToString()
        {
            var c = new Teacher("1", DateTime.Now, DateTime.Now);
            Assert.AreEqual(c.ToString(), "1", "Не верны данные");
        }

        [TestMethod]
        public void TestEducationalDisciplineToString()
        {
            var c = new EducationalDiscipline("1", "3");
            Assert.AreEqual(c.ToString(), "1", "Не верны данные");
        }

        private MockLocalSettings _mockLocalSettings = new MockLocalSettings();

        [TestMethod]
        public void TestMockClassRoom()
        {
            var g = new MockClassRoom("1", "1");
            g.AddToDatabase(_mockLocalSettings);
            string query = _mockLocalSettings.SqlQueries.First();
            Assert.AreEqual("INSERT INTO [ClassRoom] (Name, Number) VALUES(@Name, @Number)", query);
        }
    }
    
}
