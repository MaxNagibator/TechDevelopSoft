using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolManagement;
using SchoolManagement.Exceptions;
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
        
        [TestMethod]
        [ExpectedException(typeof(SqlProviderException))]
        public void TestGroupAddToDatabase()
        {
            Globals.LocalSettings = new LocalSettings();
            var g = new Group(1);
           g.AddToDatabase();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestStudentAddToDatabase()
        {
            Globals.LocalSettings = new LocalSettings();
            var g = new Student();
            g.AddToDatabase();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestClassTimeTableAddToDatabase()
        {
            Globals.LocalSettings = new LocalSettings();
            var g = new ClassTimeTable(new Group(1),DateTime.Now,new ClassTime("1",1,"1","1"));
            g.AddToDatabase();
        }
    }
}
