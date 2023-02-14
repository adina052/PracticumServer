using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public class ChildDTO
    {
        public int IdNumber { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        [ForeignKey("Parent1")]
        public int? Parent1Id { get; set; }
        [ForeignKey("Parent2")]
        public int? Parent2Id { get; set; }
        public UserDTO? Parent1 { get; set; }
        public UserDTO? Parent2 { get; set; }
        //public ChildDTO(int idNumber, int id, string name, DateTime dateBirth, int? parent1Id, int? parent2Id, UserDTO parent1, UserDTO parent2)
        //{
        //    IdNumber = idNumber;
        //    Id = id;
        //    Name = name;
        //    DateBirth = dateBirth;
        //    Parent1Id = parent1Id;
        //    Parent2Id = parent2Id;
        //    Parent1 = parent1;
        //    Parent2 = parent2;
        //}
        //public ChildDTO() { }
    }
}
