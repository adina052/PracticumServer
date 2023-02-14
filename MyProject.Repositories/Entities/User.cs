using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public enum eHMO { Macabi,Clalit,Leumit,Meuchedet}
    public class User
    {
        public int IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public DateTime DateBirth { get; set; }
        public bool Gender { get; set; }
        public eHMO HMO { get; set; }
       
        public User() { }
        public User(int idNumber, string firstName, string lastName, int iD, DateTime dateBirth, bool gender, eHMO hMO)
        {
            IdNumber = idNumber;
            FirstName = firstName;
            LastName = lastName;
            Id = iD;
            DateBirth = dateBirth;
            Gender = gender;
            HMO = hMO;
        }
    }
}
