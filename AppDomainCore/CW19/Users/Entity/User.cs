using CW19.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace CW19.Models.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public string NationalCode { get; set; }
        public string Phone { get; set; }
        public MembershipEnum MembershipType { get; set; }
        public GenderEnum Gender { get; set; } 

    }
}
