namespace LibraryApplication.Models
{
    public class BorrowedBook
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid BookId { get; set; }
        public Guid BorrowerId { get; set; }
        public DateTime BorrowDate { get; set; } = DateTime.UtcNow; 
        public DateTime ReturnDate { get; set; } = DateTime.UtcNow;
        public Book Book { get; set; }
        public Borrower Borrower { get; set; }
    }
}
