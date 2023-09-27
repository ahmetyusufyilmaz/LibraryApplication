namespace LibraryApplication.Models
{
    public class Borrower
    {
        public Guid Id { get; set; } =  Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
