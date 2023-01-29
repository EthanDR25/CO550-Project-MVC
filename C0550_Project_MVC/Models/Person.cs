using System.ComponentModel.DataAnnotations;

namespace CO550_Project_Razor.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
    }
}
