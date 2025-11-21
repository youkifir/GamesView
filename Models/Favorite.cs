namespace GamesView.Models
{
    public class Favorite
    {
        public int FavoriteId { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }

        public User User { get; set; }
        public Game Game { get; set; }
    }
}