﻿using System.ComponentModel;

namespace SchoolManagement.School
{
    public class ClassRoom : Entity
    {
        public int Id { get; set; }
        [DisplayName("Номер")]
        public string Number { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }

        public ClassRoom(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public override void AddToDatabase()
        {
            DatabaseManager.AddClassRoom(Name,Number);
        }

        public override string ToString()
        {
            return Number;
        }

        public override void UpdateInDatabase(int id)
        {
            DatabaseManager.UpdateClassRoom(id, Name, Number);
        }
    }
}
