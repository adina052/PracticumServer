using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public enum eHMO { Macabi, Clalit, Leumit, Meuchedet }
    public class UserDTO

    {
        public int IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public DateTime DateBirth { get; set; }
        public bool Gender { get; set; }
        public eHMO HMO { get; set; }
        public UserDTO()
        {

        }
        public UserDTO(int idNumber, string firstName, string lastName, int id, DateTime dateBirth, bool gender, eHMO hMO)
        {
            IdNumber = idNumber;
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            DateBirth = dateBirth;
            Gender = gender;
            HMO = hMO;
        }
    }
}
