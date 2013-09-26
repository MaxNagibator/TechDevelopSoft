using System;
using System.Collections.Generic;
using System.Linq;
using SchoolManagement.School;

namespace SchoolManagement
{
    public class DatabaseManager
    {

        public static List<Group> GetGroups()
        {
            var groups = new List<Group>();
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.ExecuteQuery(@"SELECT Id
                                            ,Name
                                            ,Comment
                                        FROM [Group]
                                        ORDER BY [Name]");
                groups.AddRange(sqlProvider.Rows.Select(row =>
                                                        new Group(
                                                            row.Field<string>("Name"),
                                                            row.Field<string>("Comment"))
                                                            {
                                                                Id = row.Field<int>("Id")
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

        public static void UpdateGroup(int id, string name, string comment)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Name", name);
                sqlProvider.SetParameter("@Comment", comment);
                sqlProvider.SetParameter("@Id", id);
                sqlProvider.ExecuteQuery(@"
                    UPDATE[ClassRoom] 
                    SET Name = @Name, Comment = @Comment
                    WHERE Id = @Id");
            }
        }

        public static void DeleteGroupById(int id)
        {
            DeleteClassTimeTableByGroupId(id);
            DeleteFromTableById(id, "Group");
        }

        public static List<ClassRoom> GetClassRooms()
        {
            var classRooms = new List<ClassRoom>();
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.ExecuteQuery(@"SELECT Id
                                            ,Name
                                            ,Number
                                        FROM [ClassRoom]
                                        ORDER BY [Name]");
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
                sqlProvider.ExecuteQuery(@"
                    INSERT INTO [ClassRoom] 
                    (Name, Number)
                    VALUES(@Name, @Number)");
            }
        }

        public static void UpdateClassRoom(int id, string name, string number)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Name", name);
                sqlProvider.SetParameter("@Number", number);
                sqlProvider.SetParameter("@Id", id);
                sqlProvider.ExecuteQuery(@"
                    UPDATE[ClassRoom] 
                    SET Name = @Name, Number = @Number
                    WHERE Id = @Id");
            }
        }

        public static void DeleteClassRoomById(int id)
        {
            DeleteFromTableById(id, "ClassRoom");
        }

        public static List<ClassTime> GetClassTimes()
        {
            var classTimes = new List<ClassTime>();
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.ExecuteQuery(@"SELECT Id
                                            ,Name
                                            ,StartTime
                                            ,EndTime
                                            ,Number
                                        FROM [ClassTime]
                                        ORDER BY [Number]");
                classTimes.AddRange(sqlProvider.Rows.Select(row =>
                                                            new ClassTime(
                                                                row.Field<int>("Number"),
                                                                row.Field<string>("StartTime"),
                                                                row.Field<string>("EndTime"))
                                                                {
                                                                    Id = row.Field<int>("Id")
                                                                }));
            }
            return classTimes;
        }

        public static void AddClassTime(string name, int number, string startTime, string endTime)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Name", name);
                sqlProvider.SetParameter("@StartTime", startTime);
                sqlProvider.SetParameter("@EndTIme", endTime);
                sqlProvider.SetParameter("@Number", number);
                sqlProvider.ExecuteQuery(@"INSERT INTO [ClassTime] 
                    (Name, Number, StartTime, EndTime)
                    VALUES(@Name, @Number, @StartTime, @EndTime)");
            }
        }

        public static void UpdateClassTime(int id, string name, int number, string startTime, string endTime)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Name", name);
                sqlProvider.SetParameter("@StartTime", startTime);
                sqlProvider.SetParameter("@EndTIme", endTime);
                sqlProvider.SetParameter("@Number", number);
                sqlProvider.SetParameter("@Id", id);
                sqlProvider.ExecuteQuery(@"
                    UPDATE[ClassRoom] 
                    SET Name = @Name, StartTime = @StartTime, EndTIme = @EndTIme, Number = @Number
                    WHERE Id = @Id");
            }
        }

        public static void DeleteClassTimeById(int id)
        {
            DeleteFromTableById(id, "ClassTime");
        }

        public static List<ClassTimeTable> GetClassTimeTables()
        {
            var classTimes = new List<ClassTimeTable>();
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.ExecuteQuery(
                    @"SELECT [ClassTimeTable].[Id]
                        ,[ClassTimeTable].[Name]
                        ,[ClassTimeTable].[Date]
                        ,[ClassTime].[Id] AS ClassTimeId
                        ,[ClassTime].[StartTime] AS ClassTimeStartTime
                        ,[ClassTime].[EndTime] AS ClassTimeEndTime
                        ,[ClassTime].[Name] AS ClassTimeName
                        ,[ClassTime].[Number] AS ClassTime
                        ,[EducationalDiscipline].[Id] AS EducationalDisciplineId
                        ,[EducationalDiscipline].[Name] AS EducationalDisciplineName
                        ,[EducationalDiscipline].[Description] AS EducationalDisciplineDescription
                        ,[Teacher].[Id] AS TeacherId
                        ,[Teacher].[Name] AS TeacherName
                        ,[Teacher].[BirthDay] AS TeacherBirthDay
                        ,[Teacher].[StartWorkDate] AS TeacherStartWorkDate
                        ,[ClassRoom].[Id] AS ClassRoomId
                        ,[ClassRoom].[Name] AS ClassRoomName
                        ,[ClassRoom].[Number] AS ClassRoomNumber
                        ,[Group].[Id] AS GroupId
                        ,[Group].[Name] AS GroupName
                        ,[Group].[Comment] AS GroupComment                        
                    FROM [ClassTimeTable]
                        INNER JOIN [ClassTime] ON [ClassTime].[Id] = [ClassTimeTable].[ClassTimeId]
                        INNER JOIN [EducationalDiscipline] ON [EducationalDiscipline].[Id] = [ClassTimeTable].[EducationalDisciplineId]
                        INNER JOIN [Teacher] ON [Teacher].[Id] = [ClassTimeTable].[TeacherId]
                        INNER JOIN [ClassRoom] ON [ClassRoom].[Id] = [ClassTimeTable].[ClassRoomId]
                        INNER JOIN [Group] ON [Group].[Id] = [ClassTimeTable].[GroupId]");
                classTimes.AddRange(sqlProvider.Rows.Select(
                    row =>
                    new ClassTimeTable(
                        row.Field<string>("Name"),
                        row.Field<DateTime>("Date"),
                        new ClassTime(
                            row.Field<int>("ClassTime"),
                            row.Field<string>("ClassTimeStartTime"),
                            row.Field<string>("ClassTimeEndTime"))
                            {
                                Id = row.Field<int>("ClassTimeId")
                            },
                        new EducationalDiscipline(
                            row.Field<string>("EducationalDisciplineName"),
                            row.Field<string>("EducationalDisciplineDescription"))
                            {
                                Id = row.Field<int>("EducationalDisciplineId")
                            },
                        new Teacher(
                            row.Field<string>("TeacherName"),
                            row.Field<DateTime>("TeacherBirthDay"),
                            row.Field<DateTime>("TeacherStartWorkDate"))
                            {
                                Id = row.Field<int>("TeacherId")
                            },
                        new ClassRoom(
                            row.Field<string>("ClassRoomName"),
                            row.Field<string>("ClassRoomNumber"))
                            {
                                Id = row.Field<int>("ClassRoomId")
                            },
                        new Group(
                            row.Field<string>("GroupName"),
                            row.Field<string>("GroupComment"))
                            {
                                Id = row.Field<int>("GroupId")
                            })
                        {
                            Id = row.Field<int>("Id")
                        }));

            }
            return classTimes;
        }

        public static void AddClassTimeTable(string name, int classTimeId, int educationalDisciplineId, DateTime date, int teacherId, int classRoomId, int groupId)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Name", name);
                sqlProvider.SetParameter("@ClassTimeId", classTimeId);
                sqlProvider.SetParameter("@EducationalDisciplineId", educationalDisciplineId);
                sqlProvider.SetParameter("@Date", date);
                sqlProvider.SetParameter("@TeacherId", teacherId);
                sqlProvider.SetParameter("@ClassRoomId", classRoomId);
                sqlProvider.SetParameter("@GroupId", groupId);
                sqlProvider.ExecuteQuery(
                    @"INSERT INTO [ClassTimeTable] 
                        (Name,Date, ClassTimeId,EducationalDisciplineId,TeacherId,ClassRoomId,GroupId)
                        VALUES(@Name,@Date, @ClassTimeId,@EducationalDisciplineId,@TeacherId,@ClassRoomId,@GroupId)");
            }
        }

        public static void UpdateClassTimeTable(int id, string name, int classTimeId, int educationalDisciplineId, DateTime date, int teacherId, int classRoomId, int groupId)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Name", name);
                sqlProvider.SetParameter("@ClassTimeId", classTimeId);
                sqlProvider.SetParameter("@EducationalDisciplineId", educationalDisciplineId);
                sqlProvider.SetParameter("@Date", date);
                sqlProvider.SetParameter("@TeacherId", teacherId);
                sqlProvider.SetParameter("@ClassRoomId", classRoomId);
                sqlProvider.SetParameter("@GroupId", groupId);
                sqlProvider.SetParameter("@Id", id);
                sqlProvider.ExecuteQuery(@"
                    UPDATE[ClassRoom] 
                    SET Name = @Name
                        ,ClassTimeId = @ClassTimeId
                        ,EducationalDisciplineId = @EducationalDisciplineId
                        ,Date = @Date
                        ,TeacherId = @TeacherId
                        ,ClassRoomId = @ClassRoomId
                        ,GroupId = @GroupId
                    WHERE Id = @Id");
            }
        }

        public static void DeleteClassTimeTableById(int id)
        {
            DeleteFromTableById(id, "ClassTimeTable");
        }

        private static void DeleteClassTimeTableByGroupId(int groupId)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@GroupId", groupId);
                sqlProvider.ExecuteQuery(
                    @"DELETE FROM [ClassTimeTable]
                    WHERE GroupId = @GroupId");
            }
        }

        public static List<EducationalDiscipline> GetEducationalDisciplines()
        {
            var educationalDisciplines = new List<EducationalDiscipline>();
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.ExecuteQuery(@"SELECT .[EducationalDiscipline].[Id]
                                            ,[EducationalDiscipline].[Name]
                                            ,[EducationalDiscipline].[Description]
                                        FROM [EducationalDiscipline]
                                        ORDER BY [Name]");
                educationalDisciplines.AddRange(sqlProvider.Rows
                                      .Select(row =>
                                              new EducationalDiscipline(row.Field<string>("Name"),
                                                          row.Field<string>("Description"))
                                                  {
                                                      Id = row.Field<int>("id")
                                                  }));
                return educationalDisciplines;
            }
        }

        public static void AddEducationalDiscipline(string name, string description)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Name", name);
                sqlProvider.SetParameter("@Description", description);
                sqlProvider.ExecuteQuery(@"INSERT INTO [EducationalDiscipline] 
                    (Name, Description) 
                    VALUES(@Name, @Description)");
            }
        }

        public static void UpdateEducationalDiscipline(int id, string name, string description)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Name", name);
                sqlProvider.SetParameter("@Description", description);
                sqlProvider.SetParameter("@Id", id);
                sqlProvider.ExecuteQuery(@"
                    UPDATE[ClassRoom] 
                    SET Name = @Name, Description = @Description
                    WHERE Id = @Id");
            }
        }

        public static void DeleteEducationalDisciplineById(int id)
        {
            DeleteFromTableById(id, "EducationalDiscipline");
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
                                        FROM [Teacher]
                                        ORDER BY [Name]");
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

        public static void UpdateTeacher(int id, string name, DateTime birthDay, DateTime startWorkDate)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Name", name);
                sqlProvider.SetParameter("@BirthDay", birthDay);
                sqlProvider.SetParameter("@StartWorkDate", startWorkDate);
                sqlProvider.SetParameter("@Id", id);
                sqlProvider.ExecuteQuery(@"
                    UPDATE[ClassRoom] 
                    SET Name = @Name, BirthDay = @BirthDay, StartWorkDate = @StartWorkDate
                    WHERE Id = @Id");
            }
        }

        public static void DeleteTeacherById(int id)
        {
            DeleteFromTeacherAbilityByTeacherId(id);
            DeleteFromTableById(id, "Teacher");
        }

        private static void DeleteFromTeacherAbilityByTeacherId(int teacherId)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Id", teacherId);
                sqlProvider.ExecuteQuery(
                    @"DELETE FROM [TeacherAbility] 
                    WHERE TeacherId = @Id");
            }
        }

        private static void DeleteFromTableById(int id, string tableName)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Id", id);
                sqlProvider.ExecuteQuery(
                    @"DELETE FROM [" + tableName + @"] 
                    WHERE Id = @Id");
            }
        }
    }
}
