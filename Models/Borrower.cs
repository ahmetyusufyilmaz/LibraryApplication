using System.ComponentModel.DataAnnotations;

namespace LibraryApplication.Models
{
    public class Borrower: BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [MaxLength(11)]
        public string PhoneNumber { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
