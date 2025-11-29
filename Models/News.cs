namespace GamesView.Models
{
    public class News
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DatePosted { get; set; }
        public string? Author { get; set; }
        public string? ImageUrl { get; set; }
    }
}