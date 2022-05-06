namespace Core.Models
{
    public class Book
    {
        protected long Id { get; set; }
        public string Name { get; set; }
        public string PublishedAt { get; set; }
        public int AvailableCopies { get; set; }
        protected long AuthorId { get; set; }
    }
}
