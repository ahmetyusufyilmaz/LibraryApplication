namespace LibraryApplication.Models
{
    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Author { get; set; }
        public byte[]? Image { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
