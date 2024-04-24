namespace SSBlogs.Models
{
    public class Comment
    {
        public required int Id { get; set; }
        public Blog Blog { get; set; }
        public required int BlogId { get; set; }
        public required string Comments { get; set; }
        public required DateTime TimeStamp { get; set; }
    }
}