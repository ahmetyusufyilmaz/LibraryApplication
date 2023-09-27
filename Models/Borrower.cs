using System.ComponentModel.DataAnnotations;

namespace LibraryApplication.Models
{
    public class Borrower
    {
        public Guid Id { get; set; } =  Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [MaxLength(11)]
        public string PhoneNumber { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
