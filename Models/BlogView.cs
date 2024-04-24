namespace SSBlogs.Models
{
    public class BlogView
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string AuthorName { get; set; }
        public required string Description { get; set; }
        public DateTime PublishedOn { get; set; }
    }
}