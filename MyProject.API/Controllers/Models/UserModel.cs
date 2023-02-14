using MyProject.Common.DTOs;
using System;

namespace MyProject.WebAPI.Controllers.Models
{
    public class UserModel
    {
        public int IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public DateTime DateBirth { get; set; }
        public bool Gender { get; set; }
        public eHMO HMO { get; set; }
    }
}
