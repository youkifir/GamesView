using GamesView.Data;
using GamesView.Models;
using Microsoft.EntityFrameworkCore;

public class ReviewService
{
    private readonly AppDbContext _context;

    public ReviewService(AppDbContext context)
    {
        _context = context;
    }

    // Добавить отзыв
    public async Task<bool> AddReviewAsync(int userId, int gameId, string text, int? rating = null)
    {
        try
        {
            bool exists = await _context.Reviews
                .AnyAsync(r => r.UserId == userId && r.GameId == gameId);

            if (exists) return false;

            var review = new Review
            {
                UserId = userId,
                GameId = gameId,
                Text = text,
                Rating = rating,
                CreatedAt = DateTime.Now
            };

            _context.Reviews.Add(review);
            return await _context.SaveChangesAsync() > 0;
        }
        catch
        {
            return false;
        }
    }

    // Получить отзывы для игры
    public async Task<List<Review>> GetGameReviewsAsync(int gameId)
    {
        return await _context.Reviews
            .Where(r => r.GameId == gameId)
            .Include(r => r.User)
            .OrderByDescending(r => r.CreatedAt)
            .ToListAsync();
    }

    // Получить отзывы пользователя
    public async Task<List<Review>> GetUserReviewsAsync(int userId)
    {
        return await _context.Reviews
            .Where(r => r.UserId == userId)
            .Include(r => r.Game)
            .ToListAsync();
    }

    // Удалить отзыв
    public async Task<bool> DeleteReviewAsync(int reviewId)
    {
        try
        {
            var review = await _context.Reviews.FindAsync(reviewId);
            if (review == null) return false;

            _context.Reviews.Remove(review);
            return await _context.SaveChangesAsync() > 0;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> CanUserDeleteReviewAsync(int userId, int reviewId)
    {
        var review = await _context.Reviews.FindAsync(reviewId);
        if (review == null) return false;

        if (review.UserId == userId) return true;

        var user = await _context.Users.FindAsync(userId);
        return user?.RoleId == 2; // 2 = Admin
    }

    // Получить средний рейтинг игры
    public async Task<double> GetGameRatingAsync(int gameId)
    {
        var ratings = await _context.Reviews
            .Where(r => r.GameId == gameId && r.Rating.HasValue)
            .Select(r => r.Rating.Value)
            .ToListAsync();

        return ratings.Any() ? ratings.Average() : 0;
    }

}