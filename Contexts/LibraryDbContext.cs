using LibraryApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApplication.Contexts
{
    public class LibraryDbContext:DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BorrowedBook>()
                .HasKey(bb => bb.Id);

            // Kitap ile BorrowedBook arasındaki ilişkiyi tanımlayın
            modelBuilder.Entity<BorrowedBook>()
                .HasOne(bb => bb.Book)
                .WithMany()
                .HasForeignKey(bb => bb.BookId);

            // Ödünç alan kullanıcı ile BorrowedBook arasındaki ilişkiyi tanımlayın
            modelBuilder.Entity<BorrowedBook>()
                .HasOne(bb => bb.Borrower)
                .WithMany()
                .HasForeignKey(bb => bb.BorrowerId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Borrower> Borrowers { get; set; }

        public DbSet<BorrowedBook> BorrowedBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=CustomerDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }
    }
}

