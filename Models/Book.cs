namespace LibraryApplication.Models
{
    public class Book: BaseClass
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public byte[]? Image { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
