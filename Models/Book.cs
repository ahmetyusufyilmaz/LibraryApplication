namespace LibraryApplication.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Image { get; set; }
        public bool IsAvailable { get; set; }
    }
}
