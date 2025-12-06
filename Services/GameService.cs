using GamesView.Data;
using GamesView.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesView.Services
{
    public class GameService
    {
        private readonly AppDbContext _context;
        public GameService(AppDbContext context) => _context = context;

        public async Task<List<Game>> GetGamesAsync() => await _context.Games.ToListAsync();
        public async Task<Game> GetGameByIdAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID гри має бути більше 0", nameof(id));

            var game = await _context.Games
                .FirstOrDefaultAsync(g => g.GameId == id);

            if (game == null)
            {
                throw new KeyNotFoundException($"Гру з ID {id} не знайдено");
            }

            return game;
        }
        public async Task<(bool success, string message)> AddGameAsync(Game game)
        {
            try
            {
                if (game == null)
                    return (false, "Гра не може бути null");

                if (string.IsNullOrWhiteSpace(game.Title))
                    return (false, "Введіть назву гри");

                if (await _context.Games.AnyAsync(g => g.Title == game.Title))
                    return (false, "Гра з такою назвою вже існує");

                _context.Games.Add(game);
                int result = await _context.SaveChangesAsync();

                return (result > 0, result > 0 ? "Гру успішно додано" : "Не вдалося зберегти гру");
            }
            catch (DbUpdateException ex)
            {
                return (false, $"Помилка бази даних: {ex.InnerException?.Message ?? ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Сталася помилка: {ex.Message}");
            }
        }

        public async Task<(bool success, string message)> UpdateGameAsync(Game game)
        {
            try
            {
                if (game == null)
                    return (false, "Гра не може бути null");

                if (game.GameId <= 0)
                    return (false, "Невірний ID гри");

                if (string.IsNullOrWhiteSpace(game.Title))
                    return (false, "Введіть назву гри");

                if (game.ReleaseYear < 1950 || game.ReleaseYear > DateTime.Now.Year + 2)
                    return (false, "Невірний рік випуску");

                if (game.Rating < 0 || game.Rating > 10)
                    return (false, "Рейтинг повинен бути від 0 до 10");

                if (await _context.Games.AnyAsync(g => g.Title == game.Title && g.GameId != game.GameId))
                    return (false, "Гра з такою назвою вже існує");

                _context.Games.Update(game);
                int result = await _context.SaveChangesAsync();

                return (result > 0, result > 0 ? "Гра успішно оновлена" : "Не вдалося оновити гру");
            }
            catch (DbUpdateException ex)
            {
                return (false, $"Помилка бази даних: {ex.InnerException?.Message ?? ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Сталася помилка: {ex.Message}");
            }
        }
        public async Task<(bool success, string message)> DeleteGameAsync(int id)
        {
            try
            {
                if (id <= 0)
                    return (false, "Невірний ID гри");

                var game = await _context.Games.FirstOrDefaultAsync(g => g.GameId == id);
                if (game == null)
                    return (false, "Гру не знайдено");

                // 1️⃣ Видаляємо гру з улюблених (інакше буде FK помилка)
                var favorites = _context.Favorites.Where(f => f.GameId == id);
                _context.Favorites.RemoveRange(favorites);

                // 2️⃣ Видаляємо відгуки, якщо вони є
                var reviews = _context.Reviews.Where(r => r.GameId == id);
                _context.Reviews.RemoveRange(reviews);

                // 3️⃣ Видаляємо саму гру
                _context.Games.Remove(game);

                int result = await _context.SaveChangesAsync();

                return result > 0
                    ? (true, "Гру успішно видалено")
                    : (false, "Не вдалося видалити гру");
            }
            catch (DbUpdateException ex)
            {
                string errorMessage = ex.InnerException?.Message ?? ex.Message;
                return (false, $"Помилка бази даних: {errorMessage}");
            }
            catch (Exception ex)
            {
                return (false, $"Сталася помилка: {ex.Message}");
            }
        }
        // Поиск и фильтрация
        public async Task<List<Game>> SearchGamesAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return new List<Game>();

            return await _context.Games
                .Where(g => EF.Functions.Like(g.Title, $"%{searchTerm}%") ||
                           EF.Functions.Like(g.Genre, $"%{searchTerm}%") ||
                           EF.Functions.Like(g.Developer, $"%{searchTerm}%") ||
                           EF.Functions.Like(g.Description, $"%{searchTerm}%"))
                .ToListAsync();
        }
        public async Task<List<Game>> FilterGamesByGenreAsync(string genre)
        {
            return await _context.Games
                .Where(g => g.Genre.ToLower() == genre.ToLower())
                .ToListAsync();
        }
        public async Task<List<Game>> GetGamesByRatingAsync(double minRating)
        {
            return await _context.Games
                .Where(g => g.Rating >= minRating)
                .OrderByDescending(g => g.Rating)
                .ToListAsync();
        }
        public async Task<List<Game>> GetNewReleasesAsync()
        {
            var currentYear = DateTime.Now.Year;

            return await _context.Games
                .Where(g => g.ReleaseYear >= currentYear - 1)
                .OrderByDescending(g => g.ReleaseYear)
                .ThenByDescending(g => g.Rating.HasValue ? g.Rating.Value : 0)
                .ThenBy(g => g.Title)
                .ToListAsync();
        }

    }
}
