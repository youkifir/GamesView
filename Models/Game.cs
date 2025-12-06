namespace GamesView.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Title { get; set; }
        public string? Genre { get; set; }
        public string? Developer { get; set; }
        public int ReleaseYear { get; set; }
        public string? Description { get; set; }
        public double? Rating { get; set; }
        public string? CoverPath { get; set; }

        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}