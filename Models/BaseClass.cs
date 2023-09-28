namespace LibraryApplication.Models
{
    public abstract class BaseClass
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
