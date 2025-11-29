namespace GamesView.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }
        public string Text { get; set; }
        public int? Rating { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
        public Game Game { get; set; }
    }
}