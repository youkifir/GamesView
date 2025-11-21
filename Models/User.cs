namespace GamesView.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public int RoleId { get; set; }
        public DateTime DateCreated { get; set; }

        public Role Role { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}