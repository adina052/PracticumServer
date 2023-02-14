using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.WebAPI.Controllers.Models
{
    public class ChildModel
    {
        public int IdNumber { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateBirth { get; set; } 
        [ForeignKey("Parent1")]
        public int? Parent1Id { get; set; }
        [ForeignKey("Parent2")]
        public int? Parent2Id { get; set; }
        //public UserModel? Parent1 { get; set; }
        //public UserModel? Parent2 { get; set; }
    }
}
