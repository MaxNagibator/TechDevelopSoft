using System;
using System.Collections.Generic;
using System.Linq;
using SchoolManagement.School;

namespace SchoolManagement
{
    public class DatabaseManager
    {
        public static List<Student> GetStudents()
        {
            var students = new List<Student>();
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.ExecuteQuery(@"SELECT .[Student].[Id]
                                            ,[Student].[Name]
                                            ,[Student].[BirthDay]
                                            ,[Student].[GroupId]
                                            ,[Student].[Comment]
                                            ,[Group].[Name] AS GroupName
                                            ,[Group].[Comment] AS GroupComment
                                        FROM [Student]
                                        INNER JOIN [Group] ON [Group].[Id] = [Student].[GroupId]");
                students.AddRange(sqlProvider.Rows
                                      .Select(row =>
                                              new Student(row.Field<string>("Name"),
                                                          row.Field<DateTime>("BirthDay"),
                                                          row.Field<string>("Comment"),
                                                          new Group(row.Field<int>("GroupId"))
                                                              {
                                                                  Name = row.Field<string>("GroupName"),
                                                                  Comment = row.Field<string>("GroupComment")
                                                              })
                                                  {
                                                      Id = row.Field<int>("Id"),
                                                  }));
            }
            return students;
        }

        public static void AddStudent(string name, DateTime birthDay, string comment, int groupId)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Name", name);
                sqlProvider.SetParameter("@BirthDay", birthDay);
                sqlProvider.SetParameter("@Comment", comment);
                sqlProvider.SetParameter("@GroupId", groupId);
                sqlProvider.ExecuteQuery(@"INSERT INTO [Student] 
                    (Name, BirthDay, Comment, GroupId) 
                    VALUES(@Name, @BirthDay, @Comment, @GroupId)");
            }
        }

        public static List<Group> GetGroups()
        {
            var groups = new List<Group>();
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.ExecuteQuery(@"SELECT Id
                                            ,Name
                                            ,Comment
                                        FROM [Group]");
                groups.AddRange(sqlProvider.Rows.Select(row =>
                                                        new Group
                                                            {
                                                                Id = row.Field<int>("Id"),
                                                                Name = row.Field<string>("Name"),
                                                                Comment = row.Field<string>("Comment")
                                                            }));
            }
            return groups;
        }

        public static void AddGroup(string name, string comment)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Name", name);
                sqlProvider.SetParameter("@Comment", comment);
                sqlProvider.ExecuteQuery(@"INSERT INTO [Group] 
                    (Name, Comment) 
                    VALUES(@Name, @Comment)");
            }
        }

        public static List<ClassRoom> GetClassRooms()
        {
            var classRooms = new List<ClassRoom>();
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.ExecuteQuery(@"SELECT Id
                                            ,Name
                                            ,Number
                                        FROM [ClassRoom]");
                classRooms.AddRange(sqlProvider.Rows.Select(row =>
                                                            new ClassRoom(
                                                                row.Field<string>("Name"),
                                                                row.Field<string>("Number"))
                                                                {
                                                                    Id = row.Field<int>("Id")
                                                                }));
            }
            return classRooms;
        }

        public static void AddClassRoom(string name, string number)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Name", name);
                sqlProvider.SetParameter("@Number", number);
                sqlProvider.ExecuteQuery(@"INSERT INTO [ClassRoom] 
                    (Name, Number)
                    VALUES(@Name, @Number)");
            }
        }

        public static List<Teacher> GetTeachers()
        {
            var teachers = new List<Teacher>();
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.ExecuteQuery(@"SELECT .[Teacher].[Id]
                                            ,[Teacher].[Name]
                                            ,[Teacher].[BirthDay]
                                            ,[Teacher].[StartWorkDate]
                                        FROM [Teacher]");
                teachers.AddRange(sqlProvider.Rows
                                      .Select(row =>
                                              new Teacher(row.Field<string>("Name"),
                                                          row.Field<DateTime>("BirthDay"),
                                                          row.Field<DateTime>("StartWorkDate"))
                                                  {
                                                      Id = row.Field<int>("id")
                                                  }));
                return teachers;
            }
        }

        public static void AddTeacher(string name, DateTime birthDay, DateTime startWorkDate)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Name", name);
                sqlProvider.SetParameter("@BirthDay", birthDay);
                sqlProvider.SetParameter("@StartWorkDate", startWorkDate);
                sqlProvider.ExecuteQuery(@"INSERT INTO [Teacher] 
                    (Name, BirthDay, StartWorkDate) 
                    VALUES(@Name, @BirthDay, @StartWorkDate)");
            }
        }
    }
}
