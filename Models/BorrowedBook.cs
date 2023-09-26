namespace LibraryApplication.Models
{
    public class BorrowedBook
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public Guid BorrowerId { get; set; }
        public DateTime BorrowDate { get; set; }      
        public DateTime ReturnDate { get; set; }
        public Book Book { get; set; }
        public Borrower Borrower { get; set; }
    }
}
