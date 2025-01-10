using CW19.Models.Enum;

namespace CW19.Models.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationalژode { get; set; }
        public string Phone { get; set; }
        public MembershipEnum MembershipType { get; set; } = MembershipEnum.Bronze;
        public GenderEnum Gender { get; set; }

    }
}
