namespace LibraryApplication.Models
{
    public class BorrowedBook: BaseClass
    {
       
        public Guid BookId { get; set; }
        public Guid BorrowerId { get; set; } = Guid.NewGuid();
        public DateTime BorrowDate { get; set; } = DateTime.Now; 
        public DateTime? ReturnDate { get; set; }
        public Book? Book { get; set; }
        public Borrower? Borrower { get; set; }
         public string? BookName  { get; set; }
         public string? BorrowerName { get; set; }


}
}
